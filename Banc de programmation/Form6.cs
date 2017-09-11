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
using System.Text.RegularExpressions;



namespace Banc_de_programmation
{
    public partial class logiciel_à_gérer : Form
    {
        private MySqlConnection Connection = new MySqlConnection();
        private MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        private DataSet ds = new DataSet();

        Process proc = new Process();

        public logiciel_à_gérer()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;

            _ofd.FileName = "";
            _ofd.Title = "Ouvrir le fichier rar";
            _ofd.InitialDirectory = "c:\\";
            _ofd.Filter = "fichiers archive (*.rar *.7z *.zip *.cab) |*.rar; *.7z; *.zip; *.cab";
            _ofd.FilterIndex = 1;
            _ofd.RestoreDirectory = true;
            _ofd.Multiselect = false;            

            proc.StartInfo = new ProcessStartInfo("osk.exe");
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

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (label5.Text == "" || label5.Text == "Aucun fichier ajouté")
            {
                MessageBox.Show("Il faut ajouter un fichier ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nv_lp.Text != "" && nv_nom.Text != "" && nv_version.Text != "")
            {
                try
                {
                    File.Copy(@"G:\Production\Bancs de programmation\Banc CF\Logiciels\LP" + nv_lp.Text + ".cab", @"C:\Program Files\Gunnebo Group\Programmateur CF\Programmes\LP" + nv_lp.Text + ".cab");
                }
                catch
                {
                    MessageBox.Show("Une erreur est survenue pendant la copie veuillez renouveler l'opération");
                }

                string a = "INSERT INTO programmation.logiciel (Identifiant_logiciel, Nom_logiciel, Version, Code_LP) VALUES (NULL, '" + nv_nom.Text + "', '" + nv_version.Text + "', 'LP" + nv_lp.Text + "')";
                InstrucSQL(a);
                MessageBox.Show("Le logiciel a bien été ajouté ", "Logiciel ajouté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_valider.Visible = false;
                nv_nom.Text = "";
                nv_lp.Text = "";
                nv_version.Text = "";
                label5.Text = "";
                btnOuvre.Text = "Ajout du fichier";
            }
            else
            {
                MessageBox.Show("Vous devez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btn_quit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Voulez vous quitter?", "Quitter", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (r == DialogResult.OK)
            {
                //Environment.Exit(0);                //Quitte l'application
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

        private void btnOuvre_Click(object sender, EventArgs e)
        {
            try
            {
                proc.CloseMainWindow();
            }
            catch
            {
            }
            if (btnOuvre.Text == "Modifier fichier")
            {
                File.Delete(@"G:\Production\Bancs de programmation\Banc CF\Logiciels\LP" + nv_lp.Text + ".cab");
            }
            if (File.Exists(@"C:\Program Files\Gunnebo Group\Programmateur CF\Programmes\LP" + nv_lp.Text + ".cab"))
            {
                MessageBox.Show("Un ficher porte déjà ce numero de LP", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nv_lp.Text != "")
            {
                if (_ofd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(@"G:\Production\Bancs de programmation\Banc CF\Logiciels\LP" + nv_lp.Text + ".cab"))
                    {
                        File.Delete(@"G:\Production\Bancs de programmation\Banc CF\Logiciels\LP" + nv_lp.Text + ".cab");
                    }
                    File.Copy(@_ofd.FileName, @"G:\Production\Bancs de programmation\Banc CF\Logiciels\LP" + nv_lp.Text + ".cab");
                    btn_valider.Visible = true;
                    btnOuvre.Text = "Modifier fichier";
                    label5.Text = @_ofd.FileName;
                }
                else
                {
                    label5.Text = "Aucun fichier ajouté";
                    btnOuvre.Text = "Ajout du fichier";
                }
            }
            else
            {
                MessageBox.Show("Vous devez indiquer un code LP", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }//Copie du fichier en mémoire

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
        }//Appel du clavier visuel

        private void nv_version_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b'))
            {
                e.Handled = false;
                return;
            }
            if (nv_version.Text.Length == 6)
            {
                e.Handled = true;
                return;
            }
            if (char.IsNumber(e.KeyChar))
            {
                if (e.KeyChar == '²') e.Handled = true;
                else e.Handled = false;
            }
            else e.Handled = true;
        }//Limite la taille à 6 caractère numérique

        private void nv_lp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b'))
            {
                e.Handled = false;
                return;
            }
            if (nv_lp.Text.Length == 6)
            {
                e.Handled = true;
                return;
            }
            if (char.IsNumber(e.KeyChar))
            {
                if (e.KeyChar == '²') e.Handled = true;
                else e.Handled = false;
            }
            else e.Handled = true;
        }//Limite la taille à 6 caractère numérique
    }
}