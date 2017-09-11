using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using ByteFX.Data.MySqlClient;
using System.IO.Ports;
using System.Threading;

namespace Banc_de_programmation
{
    public partial class acceuil : Form
    {
        private MySqlConnection Connection = new MySqlConnection();
        private MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        private DataSet ds = new DataSet();
        private DataSet dats = new DataSet();

        public acceuil()
        {
            InitializeComponent();

            lbl_id.Focus();

            Verif_réseau();

            FormBorderStyle = FormBorderStyle.None;                     //Cache le contour de la fenêtre
            StartPosition = FormStartPosition.CenterScreen;             //Centre la fenêtre sur l'écran

            System.DateTime date;
            date = DateTime.Now.AddMinutes(2);
            do
            {
                try
                {
                    InstrucSQL("SELECT Identifiant_operateur FROM operateur");
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        lbl_id.Items.Add(dr[0].ToString());                        
                    }
                    return;
                }
                catch
                {
                }
            }
            while (DateTime.Now <= date);
            {
                MessageBox.Show("Le server de base de données n'est pas accessible");
            }
        }

        void Verif_réseau()
        {
            try
            {
                string[] files = Directory.GetFiles(@"G:\Production\Bancs de programmation\Banc CF\Logiciels", "*.*", SearchOption.AllDirectories);
                int i = 0;
                i = files.Length;
                while (--i >= 0)
                {
                    files[i] = System.IO.Path.GetFileName(files[i]);
                }
                string[] files2 = Directory.GetFiles(@"C:\Program Files\Gunnebo Group\Programmateur CF\Programmes", "*.*", SearchOption.AllDirectories);
                int j = 0;
                j = files2.Length;
                while (--j >= 0)
                {
                    files2[j] = System.IO.Path.GetFileName(files2[j]);
                }

                bool trouve;
                int add = 0;
                string[] liste = new string[200];
                for (int k = 0; k < files.Length; k++)
                {
                    trouve = false;
                    for (int l = 0; l < files2.Length; l++)
                    {
                        if (files[k] == files2[l])
                        {
                            trouve = true;
                        }
                    }
                    if (trouve == false)
                    {
                        liste[add] = files[k];
                        add++;
                    }
                }
                add = 0;
                while (liste[add] != null)
                {
                    File.Copy(@"G:\Production\Bancs de programmation\Banc CF\Logiciels\" + liste[add], @"C:\Program Files\Gunnebo Group\Programmateur CF\Programmes\" + liste[add]); // Copie du fichier
                    add++;
                }
            }
            catch
            {
                MessageBox.Show("Le réseau n'est pas disponible verifiez les connexions");
            }
        }//Fonction permettant de vérifier les logiciels présent sur le réseau
         //et si besoin recopier les fichiers manquants sur le Panel PC

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
            catch
            {
            }
        }//Interrogation de la base de données

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
        }//Quitte et éteint le PC

        private void btn_val_id_Click(object sender, EventArgs e)
        {
            string testvide = "";
            InstrucSQL("SELECT DISTINCT Code_article FROM Produit WHERE Etat = 'Actif' ORDER BY Code_article");
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                testvide = dr[0].ToString();
            }
            if (testvide != "")
            {
                string id = lbl_id.Text;
                string mdp = lbl_mdp.Text;
                lbl_mdp.Text = "";                  //Efface le texte du mot de passe
                //lbl_id.SelectedItem = null;

                InstrucSQL("SELECT * FROM operateur WHERE Identifiant_operateur = '" + id + "'");

                foreach (DataRow datr in ds.Tables[0].Rows)
                {
                    if (datr[3].ToString() == mdp && datr[0].ToString() == id)
                    {
                        programmation f = new programmation();                //
                        Visible = false;                    //Cache la fenêtre d'acceuil et
                        f.ShowDialog();                     //affiche la fenêtre de consultation
                        Visible = true;                     //de la base de données
                        return;                             //
                    }
                }
                MessageBox.Show("Identifiant ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Il faut créer des produits avant de programmer");
            }
        }//Verifie le si le mot de passe correspond à l'identifiant
        //et si un produit est déjà entré dans la base de données

        private void Ajout_op_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text == "root" && lbl_mdp.Text == "159753")
            {
                gerer_logiciel.Visible = false;
                gerer_produit.Visible = false;
                Ajout_op.Visible = false;
                consul_BBD.Visible = false;
                btn_val_id.Visible = true;
                lbl_id.SelectedItem = null;
                New_id k = new New_id();
                Visible = false;
                k.ShowDialog();
                Visible = true;
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_mdp.Focus();
                return;
            }
            lbl_mdp.Text = "";                  //Efface le texte du mot de passe
            InstrucSQL("SELECT Identifiant_operateur FROM operateur");
            lbl_id.Items.Clear();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                lbl_id.Items.Add(dr[0].ToString());
            }
        }//Lance la fenetre d'ajout opérateur

        private void Clavier_Clic(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "C")
            {
                lbl_mdp.Text = "";
            }
            else
            {
                lbl_mdp.Text += b.Text;
            }

        }//Enregistre la saisie d'un bouton du clavier

        private void lbl_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_mdp.Focus();
            if (lbl_id.Text == "root")
            {
                gerer_logiciel.Visible = true;
                gerer_produit.Visible = true;
                Ajout_op.Visible = true;
                consul_BBD.Visible = true;
                btn_val_id.Visible = false;
            }
            else
            {
                gerer_logiciel.Visible = false;
                gerer_produit.Visible = false;
                Ajout_op.Visible = false;
                consul_BBD.Visible = false;
                btn_val_id.Visible = true;
            }
        }//Affiche soit les possibilité offerte à root soit au opérateurs

        private void gerer_produit_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text == "root" && lbl_mdp.Text == "159753")
            {
                gerer_logiciel.Visible = false;
                gerer_produit.Visible = false;
                Ajout_op.Visible = false;
                consul_BBD.Visible = false;
                btn_val_id.Visible = true;
                lbl_id.SelectedItem = null;
                produit_a_gerer n = new produit_a_gerer();
                Visible = false;
                n.ShowDialog();
                Visible = true;
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_mdp.Focus();
            }
            lbl_mdp.Text = "";                  //Efface le texte du mot de passe
        }//Lance la fenêtre d'ajout de produit et activation désactivation de produits

        private void gerer_logiciel_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text == "root" && lbl_mdp.Text == "159753")
            {
                gerer_logiciel.Visible = false;
                gerer_produit.Visible = false;
                Ajout_op.Visible = false;
                consul_BBD.Visible = false;
                btn_val_id.Visible = true;
                lbl_id.SelectedItem = null;
                logiciel_à_gérer w = new logiciel_à_gérer();
                Visible = false;
                w.ShowDialog();
                Visible = true;
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_mdp.Focus();
            }
            lbl_mdp.Text = "";                  //Efface le texte du mot de passe
        }//Lance la fenêtre des gestion des logiciels

        private void consul_BBD_Click(object sender, EventArgs e)
        {
            if (lbl_id.Text == "root" && lbl_mdp.Text == "159753")
            {
                gerer_logiciel.Visible = false;
                gerer_produit.Visible = false;
                Ajout_op.Visible = false;
                consul_BBD.Visible = false;
                btn_val_id.Visible = true;
                lbl_id.SelectedItem = null;
                lbl_mdp.Text = "";
                base_donnees r = new base_donnees();//
                Visible = false;                    //Cache la fenêtre d'acceuil et
                r.ShowDialog();                     //affiche la fenêtre de base de données
                Visible = true;                     //
                return;
            }
            else
            {
                MessageBox.Show("Mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_mdp.Text = "";
                lbl_mdp.Focus();
            }             
        }//Lance la fenêtre de consultation de la base de données

        private void lbl_mdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lbl_mdp.Text.Length == 10)
            {
                e.Handled = true;
                return;
            }
        }//Verifie que le mot de passe ne dépasse pas 10 caractères
    }
}

