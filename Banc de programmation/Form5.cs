using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using ByteFX.Data.MySqlClient;
using System.Collections;
using System.IO;
using System.IO.Ports;

namespace Banc_de_programmation
{
    public partial class produit_a_gerer : Form
    {
        private MySqlConnection Connection = new MySqlConnection();
        private MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        private DataSet ds = new DataSet();

        Process proc = new Process();

        public produit_a_gerer()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;

            //Préparation du filtre pour l'ajout de la photo
            _ofd.FileName = "";
            _ofd.Title = "Ouvrir le fichier rar";
            _ofd.InitialDirectory = "c:\\";
            _ofd.Filter = "fichiers image (*.jpeg *.bmp *.png) |*.jpg; *.bmp; *.png";
            _ofd.FilterIndex = 1;
            _ofd.RestoreDirectory = true;
            _ofd.Multiselect = false; 

            proc.StartInfo = new ProcessStartInfo("osk.exe");

            InstrucSQL("SELECT DISTINCT Code_LP FROM logiciel");
            code_lp.Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                code_lp.Items.Add(dr[0].ToString());
            }
            if (code_lp.Items.Count == 0)
            {
                nom_prod.Text = "";
                code_arti.Text = "";
                code_lp.Text = "";
                photo.Visible = false;
                MessageBox.Show("Il faut d'abord créer un logiciel");
            }
            InstrucSQL("SELECT DISTINCT Code_article FROM produit ");
            comb_prod.Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                comb_prod.Items.Add(dr[0].ToString());
                comboBox1.Items.Add(dr[0].ToString());
            }
            InstrucSQL("SELECT DISTINCT Code_LP FROM logiciel ");
            comb_LP.Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                comb_LP.Items.Add(dr[0].ToString());
            }
        }

        void InstrucSQL(string a)
        {
            string ConnnectionStr = String.Empty;

            // On définit la chaine de connexion
            ConnnectionStr = "Database=programmation;Data Source=localhost;User Id=root;Password=";
            Connection.ConnectionString = ConnnectionStr;

            try
            {
                // Ouverture de la connexion
                Connection.Open();

                // Définition de la requête SELECT à exécuter
                string MySQLCmd = a;   //phpbb_users

                // Association cette requête à la propriété SelectCommand du MySqlDataAdapter
                MyAdapter.SelectCommand = new MySqlCommand(MySQLCmd, Connection);

                // Mise dans le dataset des résultats de la commande SELECT
                ds.Reset();
                MyAdapter.Fill(ds);

                // Fermeture de la connexion
                Connection.Close();
            }
            catch (MySqlException Ex)
            {
                Connection.Close();
                MessageBox.Show("Erreur SQL:\n" + Ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Interrogation de la BDD

        private void valid_nv_Click(object sender, EventArgs e)
        {
            if (nom_prod.Text == "" || code_arti.Text == "" || code_lp.SelectedItem == null || actiobso.SelectedItem == null)
            {
                MessageBox.Show("Vous devez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string iden_logi = "";
            InstrucSQL("SELECT Identifiant_logiciel FROM logiciel WHERE Code_LP LIKE '" + code_lp.Text + "'");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                iden_logi = dr[0].ToString();
            }
            InstrucSQL("INSERT INTO programmation.produit (Identifiant_produit, Nom_produit, Code_article, Identifiant_logiciel, Code_LP, Image, Etat) VALUES (NULL, '" + nom_prod.Text + "', '" + code_arti.Text + "' ,'" + iden_logi + "' ,'" + code_lp.Text + "', NULL, '" + actiobso.Text+ "');");

            nom_prod.Text = "";
            code_arti.Text = "";
            code_lp.Text = "";
            photo.Text = "Ajouter une photo";
            photo.Visible = false;
            image.Visible = false;
            MessageBox.Show("Le produit a bien été ajouté", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            actiobso.SelectedItem = null;
            code_lp.SelectedItem = null;
            try
            {
                proc.CloseMainWindow();
            }
            catch
            {
            }
        }//Enregistre le nouveau produit dans la base de données

        private void comb_prod_SelectedIndexChanged(object sender, EventArgs e)
        {
            InstrucSQL("SELECT Etat FROM produit WHERE Code_article LIKE '"+comb_prod.Text+"'");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (dr[0].ToString() == "Actif") radio_actif.Select();
                if (dr[0].ToString() == "Obsolete") radio_obsolete.Select();
            }
        }//Affiche l'état du produit sélectionné

        private void btn_quit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Voulez vous quitter?", "Quitter", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "shutdown.exe";
                proc.StartInfo.Arguments = " -s -t 0";
                proc.Start();
                proc.Close();
            }
        }//Quitte le programme

        private void btn_deconnect_Click(object sender, EventArgs e)
        {
            FormCollection nbforms = Application.OpenForms;
            nbforms["acceuil"].Controls["lbl_id"].Text = "";
            try
            {
                proc.CloseMainWindow();
            }
            catch
            {
            }
            this.Visible = false;
        }//Retour à l'écran d'accueil

        private void valid_chgt_Click(object sender, EventArgs e)
        {
            string etat = "";
            if (radio_obsolete.Checked) etat="Obsolete";
            if (radio_actif.Checked) etat="Actif";
            InstrucSQL("UPDATE programmation.produit SET Etat = '" + etat + "' WHERE produit.Code_article LIKE '" + comb_prod.Text + "'");
            MessageBox.Show("Le produit "+ comb_prod.SelectedText+"est maintenant "+etat+" ", "Chagement effectué", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comb_prod.SelectedItem = null;
        }//Valide le chagement d'état

        private void radio_actif_CheckedChanged(object sender, EventArgs e)
        {
            valid_chgt.Visible = true;
        }//Affiche le bouton de validation uniquement en cas de changement

        private void radio_obsolete_CheckedChanged(object sender, EventArgs e)
        {
            valid_chgt.Visible = true;
        }//Affiche le bouton de validation uniquement en cas de changement

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            image.Visible = false;
            photo.Text = "Ajouter une photo";
            nom_prod.Text = "";
            code_arti.Text = "";
            code_lp.Text = "";
            actiobso.SelectedItem = null;
            comb_LP.SelectedItem = null;
            comboBox1.SelectedItem = null;
            comb_prod.SelectedItem = null;

            photo.Visible = false;
            try
            {
                proc.CloseMainWindow();
            }
            catch
            {
            }
        }//Annule et revient au choix précédent

        private void clavier_visuel_Click(object sender, EventArgs e)
        {
            try
            {
                proc.CloseMainWindow();
            }
            catch
            {
            }
            proc.Start();
        }//Affiche le clavier visuel

        private void actiobso_SelectedIndexChanged(object sender, EventArgs e)
        {
            valid_nv.Visible = true;
            photo.Visible = true;
        }//

        private void photo_Click(object sender, EventArgs e)
        {
            if (photo.Text == "Modifier la photo")
            {
                File.Delete(@"C:\Program Files\Gunnebo Group\Programmateur CF\Images\" + code_arti.Text + ".jpg");
                if (_ofd.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(@_ofd.FileName, @"C:\Program Files\Gunnebo Group\Programmateur CF\Images\" + code_arti.Text + ".jpg");
                    image.ImageLocation = @"C:\Program Files\Gunnebo Group\Programmateur CF\Images\" + code_arti.Text + ".jpg";
                    image.SizeMode = PictureBoxSizeMode.StretchImage;
                    image.Visible = true;
                }
            }
            if (photo.Text == "Ajouter une photo")
            {
                if (code_arti.Text != "")
                {
                    if (_ofd.ShowDialog() == DialogResult.OK)
                    {
                        File.Copy(@_ofd.FileName, @"C:\Program Files\Gunnebo Group\Programmateur CF\Images\" + code_arti.Text + ".jpg");
                        image.ImageLocation = @"C:\Program Files\Gunnebo Group\Programmateur CF\Images\" + code_arti.Text + ".jpg";
                        image.SizeMode = PictureBoxSizeMode.StretchImage;
                        image.Visible = true;
                        photo.Text = "Modifier la photo";
                    }
                }
                else
                {
                    MessageBox.Show("Vous devez au préalable entrer un numéro de code article");
                }
            }
        }//Enregistre la photo. Si elle est déjà enregistrée on la modifie

        private void code_arti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b'))
            {
                e.Handled = false;
                return;
            }
            if (code_arti.Text.Length == 8)
            {
                e.Handled = true;
                return;
            }
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }//Limite la saisie du code article à 6 caractères numériques

        private void Valid_maj_logi_Click(object sender, EventArgs e)
        {
            string identifiant = "";
            InstrucSQL("SELECT Identifiant_logiciel FROM logiciel WHERE Code_LP = '"+ comb_LP.Text +"'");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                identifiant = dr[0].ToString();
            }
            InstrucSQL("UPDATE programmation.produit SET Identifiant_logiciel = '"+ identifiant +"' WHERE Code_article LIKE '"+ comboBox1.Text+"'");
            InstrucSQL("UPDATE programmation.produit SET Code_LP = '" + comb_LP.Text+"' WHERE Code_article LIKE '"+ comboBox1.Text+"'");
            MessageBox.Show("Le logiciel à bien été mis a jour");
            comb_LP.SelectedItem = null;
            comboBox1.SelectedItem = null;
        }
    }
}