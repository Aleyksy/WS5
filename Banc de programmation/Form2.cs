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
using System.Threading;



namespace Banc_de_programmation
{
    public partial class programmation : Form
    {
        private int lignesImprime;
        private bool demande_change_code = true;
        private MySqlConnection Connection = new MySqlConnection();
        private MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        private DataSet ds = new DataSet();
        private DataSet dset = new DataSet();
        SerialPort COM = new SerialPort();
        string SQL_target = "localhost";

        public bool attente = false;

        public string[] lignes;//Tableau de stockage des données à imprimer

        public programmation()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            FormCollection nbforms = Application.OpenForms;
            lbl_id_op.Text = nbforms["acceuil"].Controls["lbl_id"].Text;
            InstrucSQL("SELECT numero_serie FROM programmation where identifiant_programmation IN (SELECT MAX( identifiant_programmation )FROM programmation)");

            string n_serie = "";
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                n_serie = dr[0].ToString();
            }
            if (n_serie == "") n_serie = "09ABZ00000";
            Int32 val;
            lbl_n_serie.Text = n_serie[7].ToString() + n_serie[8].ToString() + n_serie[9].ToString();
            lbl_n_lot.Text = n_serie[5].ToString() + n_serie[6].ToString();
            val = Convert.ToInt32(lbl_n_serie.Text.Trim());
            val++;
            lbl_n_serie.Text = String.Format("{0:000}", val);

            InstrucSQL("SELECT DISTINCT Code_article FROM Produit WHERE Etat = 'Actif' ORDER BY Code_article");
            // On affiche les données dans le combobox
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                comb_prod.Items.Add(dr[0].ToString());
            }
            if (comb_prod.Items.Count == 0) MessageBox.Show("Il faut créer des produits avant de programmer");
            string date = "";
            string dat = n_serie[0].ToString() + n_serie[1].ToString();
            date = DateTime.Now.ToString("yy");
            string mois = "";
            string moi = "";
            mois = DateTime.Now.ToString("MM");
            switch (mois)
            {
                case ("01"):
                    { moi = "A"; break; }
                case ("02"):
                    { moi = "B"; break; }
                case ("03"):
                    { moi = "C"; break; }
                case ("04"):
                    { moi = "D"; break; }
                case ("05"):
                    { moi = "E"; break; }
                case ("06"):
                    { moi = "F"; break; }
                case ("07"):
                    { moi = "G"; break; }
                case ("08"):
                    { moi = "H"; break; }
                case ("09"):
                    { moi = "I"; break; }
                case ("10"):
                    { moi = "J"; break; }
                case ("11"):
                    { moi = "K"; break; }
                case ("12"):
                    { moi = "L"; break; }
                default :
                    { moi = "A"; break; }
            }
            if (Convert.ToInt32(dat.Trim()) < Convert.ToInt32(date.Trim()))
            {
                lbl_n_lot.Text = "00"; lbl_n_serie.Text = "000";
            }
        }//Chargement de listbox et mise en mémoire du dernier numéro de série

        void InstrucSQL(string a)
        {
            string ConnnectionStr = String.Empty;

            // On définit la chaine de connexion
            ConnnectionStr = "Database=programmation;Data Source="+SQL_target+";User Id=root;Password=";
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

        public string GetFileSHA1CheckSum(string fichier)
        {
            System.IO.FileStream st = null;
            try
            {
                System.Security.Cryptography.SHA1CryptoServiceProvider check = new System.Security.Cryptography.SHA1CryptoServiceProvider();
                st = System.IO.File.Open(fichier, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] somme = check.ComputeHash(st);
                string ret = "";
                foreach (byte a in somme)
                {
                    if ((a < 16))
                    {
                        ret += "0" + a.ToString("X");
                    }
                    else
                    {
                        ret += a.ToString("X");
                    }
                }
                return ret;
            }
            catch 
            {
                MessageBox.Show("Contrôle intégrité impossible", "Transfert fini", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string a = "";
                return a;
            }
            finally
            {
                if (st != null) st.Close();
            }
        }//Verification de l'intégrité du fichier

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
            this.Visible = false;
        }//Retour à l'écran d'accueil

        private void comb_prod_SelectedValueChanged(object sender, EventArgs e)
        {
            panel_etik1.Visible = true;
            btn_trsf.Visible = true;
            if (File.Exists(@"C:\Program Files\Gunnebo Group\Programmateur CF\Images\" + comb_prod.Text + ".jpg"))
            {
                photo.ImageLocation = @"C:\Program Files\Gunnebo Group\Programmateur CF\Images\" + comb_prod.Text + ".jpg";
                photo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                photo.ImageLocation = @"C:\Program Files\Gunnebo Group\Programmateur CF\Images\noimage.jpg";
                photo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            photo.Visible = true;
            string date = "";
            date = DateTime.Now.ToString("yy");

            string mois = "";
            string moi = "";
            mois = DateTime.Now.ToString("MM");
            switch (mois)
            {
                case ("01"):
                    { moi = "A"; break; }
                case ("02"):
                    { moi = "B"; break; }
                case ("03"):
                    { moi = "C"; break; }
                case ("04"):
                    { moi = "D"; break; }
                case ("05"):
                    { moi = "E"; break; }
                case ("06"):
                    { moi = "F"; break; }
                case ("07"):
                    { moi = "G"; break; }
                case ("08"):
                    { moi = "H"; break; }
                case ("09"):
                    { moi = "I"; break; }
                case ("10"):
                    { moi = "J"; break; }
                case ("11"):
                    { moi = "K"; break; }
                case ("12"):
                    { moi = "L"; break; }
                default:
                    { moi = "A"; break; }
            }

            InstrucSQL("SELECT * FROM Produit WHERE Code_article = " + comb_prod.Text);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                lbl_LP.Text = dr[4].ToString();
            }
            code_article.Text = comb_prod.Text;
            LP.Text = lbl_LP.Text;
            n_serie.Text = date + moi + lbl_lieu.Text + lbl_n_lot.Text + lbl_n_serie.Text;

            InstrucSQL("SELECT Version FROM Logiciel WHERE Identifiant_logiciel IN (SELECT Identifiant_logiciel FROM Produit WHERE Code_article = " + comb_prod.Text + ")");
            string ver = null;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                ver = dr[0].ToString();
            }
            version.Text = String.Format("{0:000000}", int.Parse(ver));

            DialogResult r = MessageBox.Show("Voulez-vous créer un nouveau lot ?", "Nouveau lot", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (Convert.ToInt32(lbl_n_lot.Text.Trim()) != 99)
                {
                    Int32 val1 = Convert.ToInt32(lbl_n_lot.Text.Trim());
                    val1 = val1 + 1;
                    if (val1 == 99)
                    {
                        MessageBox.Show("Attention vous ne pourrez plus créer de nouveau lot avant le mois prochain");
                    }
                    lbl_n_lot.Text = String.Format("{0:00}", val1);
                    lbl_n_serie.Text = String.Format("{0:000}", 0);
                }
                else
                {
                    MessageBox.Show("Vous avez atteint le nombre maximal de lot en un mois");
                }
            }

        }//Interrogation BDD pour obtenir les infos sur
        //le produit sélectionné et mettre à jour la prévisualisation de l'étiquette

        private void btn_nv_lot_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbl_n_lot.Text.Trim()) != 99)
            {
                DialogResult r = MessageBox.Show("Voulez vous créer un nouveau lot?", "Nouveau lot", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (r == DialogResult.OK)
                {
                    Int32 val1 = Convert.ToInt32(lbl_n_lot.Text.Trim());
                    val1 = val1 + 1;
                    if (val1 == 99)
                    {
                        MessageBox.Show("Attention vous ne pourrez plus créer de nouveau lot avant le mois prochain");
                    }
                    lbl_n_lot.Text = String.Format("{0:00}", val1);
                    lbl_n_serie.Text = String.Format("{0:000}", 0);
                }
            }
            else
            {
                MessageBox.Show("Vous avez atteint le nombre maximal de lot en un mois");
            }
        }//Incrémentation du numéro de lot

        private void btn_trsf_MouseDown(object sender, MouseEventArgs e)
        {
            validation.Visible = false;
            erreur.Visible = false;
        }

        private void btn_trsf_MouseUp(object sender, MouseEventArgs e)
        {            
            try
            {
                Directory.CreateDirectory("E:/Updates/"); // Création du dossier
            }
            catch
            {
                MessageBox.Show("Aucune carte mémoire détectée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ThreadArgs ta = new ThreadArgs(lbl_LP.Text);
            Thread t = new Thread(new ThreadStart(ta.Run));
            t.Start();

            progressBar1.Maximum = 100000;
            progressBar1.Visible = true;

            string versi = version.Text;
            string date = "";
            date = DateTime.Now.ToString("yy");
            string mois = "";
            string moi = "";
            mois = DateTime.Now.ToString("MM");
            switch (mois)
            {
                case ("01"):
                    { moi = "A"; break; }
                case ("02"):
                    { moi = "B"; break; }
                case ("03"):
                    { moi = "C"; break; }
                case ("04"):
                    { moi = "D"; break; }
                case ("05"):
                    { moi = "E"; break; }
                case ("06"):
                    { moi = "F"; break; }
                case ("07"):
                    { moi = "G"; break; }
                case ("08"):
                    { moi = "H"; break; }
                case ("09"):
                    { moi = "I"; break; }
                case ("10"):
                    { moi = "J"; break; }
                case ("11"):
                    { moi = "K"; break; }
                case ("12"):
                    { moi = "L"; break; }
                default:
                    { moi = "A"; break; }
            }
            btn_trsf.Enabled = false;

            while (t.IsAlive)
            {
                progressBar1.Value++;
                if (progressBar1.Value == 100000) progressBar1.Value = 0;
            }
            progressBar1.Value = 99999;

            string SHA1a, SHA1b;

            SHA1a = GetFileSHA1CheckSum(@"C:\Program Files\Gunnebo Group\Programmateur CF\Programmes\" + lbl_LP.Text + ".cab");
            SHA1b = GetFileSHA1CheckSum(@"E:\Updates\update.cab");

            if (SHA1a == SHA1b)
            {
                InstrucSQL("SELECT identifiant_produit FROM Produit WHERE Code_article = " + comb_prod.Text);

                string a = "";
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    a = dr[0].ToString();
                }

                InstrucSQL("INSERT INTO programmation.programmation (Identifiant_programmation ,Numero_serie ,Date_programmation ,Identifiant_operateur ,Identifiant_produit ,Identifiant_lieu ,Nombre_programmation) VALUES (NULL, '" + date + moi + lbl_lieu.Text + lbl_n_lot.Text + lbl_n_serie.Text + "',CURRENT_TIMESTAMP , '" + lbl_id_op.Text + "', '" + a + "', '" + lbl_lieu.Text + "', '1')");

                string imprim = comb_prod.Text + " " + lbl_LP.Text + "\n" + date + moi + lbl_lieu.Text + lbl_n_lot.Text + lbl_n_serie.Text + " " + versi;
                char[] saut = { '\r' };
                lignes = imprim.Split(saut);

                printDoc.PrinterSettings.PrinterName = "Smart Label Printer 440";
                printDoc.DefaultPageSettings.Margins.Left.Equals(0);
                printDoc.DefaultPageSettings.Margins.Right.Equals(0);
                printDoc.DefaultPageSettings.Margins.Bottom.Equals(0);
                printDoc.DefaultPageSettings.Margins.Top.Equals(0);
                printDoc.Print();

                btn_trsf.Visible = true;
                validation.Visible = true;

                nv_imp.Visible = true;
                code_article2.Text = comb_prod.Text;
                n_serie_2.Text = date + moi + lbl_lieu.Text + lbl_n_lot.Text + lbl_n_serie.Text;
                LP_2.Text = lbl_LP.Text;
                version_2.Text = versi;

                Int32 val;
                val = Convert.ToInt32(lbl_n_serie.Text.Trim());
                val++;
                lbl_n_serie.Text = String.Format("{0:000}", val);
                n_serie.Text = date + moi + lbl_lieu.Text + lbl_n_lot.Text + lbl_n_serie.Text;
                attente = false;
                new_print.Visible = true;
                progressBar1.Visible = false;
            }
            else
            {
                erreur.Visible = true;
                attente = false;
                MessageBox.Show("La programmation n'est s'est pas déroulée correctement veuillez recommencer");
            }
            btn_trsf.Enabled = true;

        }//Lancement du Thread de copie
        //et affichage de la barre de progression

        private void new_print_Click(object sender, EventArgs e)
        {
            string date = "";
            date = DateTime.Now.ToString("yy");
            string mois = "";
            string moi = "";
            mois = DateTime.Now.ToString("MM");
            switch (mois)
            {
                case ("01"):
                    { moi = "A"; break; }
                case ("02"):
                    { moi = "B"; break; }
                case ("03"):
                    { moi = "C"; break; }
                case ("04"):
                    { moi = "D"; break; }
                case ("05"):
                    { moi = "E"; break; }
                case ("06"):
                    { moi = "F"; break; }
                case ("07"):
                    { moi = "G"; break; }
                case ("08"):
                    { moi = "H"; break; }
                case ("09"):
                    { moi = "I"; break; }
                case ("10"):
                    { moi = "J"; break; }
                case ("11"):
                    { moi = "K"; break; }
                case ("12"):
                    { moi = "L"; break; }
                default:
                    { moi = "A"; break; }
            }
            Int32 val;
            val = Convert.ToInt32(lbl_n_serie.Text.Trim());
            val--;
            string serie = String.Format("{0:000}", val);

            string imprim = comb_prod.Text + " " + lbl_LP.Text+ "\n" + date + moi + lbl_lieu.Text + lbl_n_lot.Text + serie +" "+version_2.Text;
            char[] saut = { '\r' };
            lignes = imprim.Split(saut);

            printDoc.PrinterSettings.PrinterName = "Smart Label Printer 440";
            printDoc.DefaultPageSettings.Margins.Left.Equals(0);
            printDoc.DefaultPageSettings.Margins.Right.Equals(0);
            printDoc.DefaultPageSettings.Margins.Bottom.Equals(0);
            printDoc.DefaultPageSettings.Margins.Top.Equals(0);
            printDoc.Print();
        }//Fonction pour la réimpression de l'étiquette

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(lignes[lignesImprime++], new Font("Arial", 10), Brushes.Black, 0, 0);
			e.HasMorePages = false;
            lignesImprime = 0;
		}//Impression de l'étiquette
    }
    public class ThreadArgs : programmation //Classe permettant de gérer le Thread pour la copie du fichier
    {
        string LP;

        public ThreadArgs(string ii)
        {
            this.LP = ii;
        }

        public void Run()
        {
            bool deleteAll = true;
            if (Directory.Exists(@"E:\BIN-WinCE"))
            {
                try
                {
                    //Suppression du dossier BIN-WinCE s'il existe
                    Directory.Delete(@"E:\BIN-WinCE", deleteAll);
                }
                catch
                {
                }
            }
            try
            {
                try
                {
                    File.Copy(@"C:\Program Files\Gunnebo Group\Programmateur CF\Programmes\" + this.LP + ".cab", @"E:\Updates\update.cab"); // Copie du fichier
                }
                catch
                {
                    File.Delete(@"E:\Updates\update.cab");
                    File.Copy(@"C:\Program Files\Gunnebo Group\Programmateur CF\Programmes\" + this.LP + ".cab", @"E:\Updates\update.cab"); // Copie du fichier
                }
            }
            catch
            {
            }
        }//Copie du fichier voulu sur la carte mémoire
    }

    public class porg_ftp : programmation
    {

    }
}