using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ByteFX.Data.MySqlClient;
using System.Reflection;
using System.IO;
using System.Threading;



namespace Banc_de_programmation
{
    public partial class base_donnees : Form
    {
        private MySqlConnection Connection = new MySqlConnection();
        private MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        private DataSet ds = new DataSet();

        public bool attente = false;
        private Thread myThread;
        object M = System.Reflection.Missing.Value;

        public base_donnees()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
          
        }

        private void btn_quit_Click_1(object sender, EventArgs e)
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
        }//Eteint le PC

        private void btn_deconnect_Click(object sender, EventArgs e)
        {
            FormCollection nbforms = Application.OpenForms;
            nbforms["acceuil"].Controls["lbl_id"].Text = "";
            this.Visible = false;
        }//Retour à l'écran d'acceuil

        private void btn_valider_Click(object sender, EventArgs e)
        {
            rec_CSV.Enabled = true;
            dataGridView1.Visible = true;
            string ConnnectionStr = String.Empty;

            // On définit la chaine de connexion
            ConnnectionStr = "Database=programmation;Data Source=localhost;User Id=root;Password=";

            Connection.ConnectionString = ConnnectionStr;

            try
            {
                // On ouvre la connexion
                Connection.Open();

                // On définit la requête SELECT à exécuter
                string MySQLCmd = "SELECT " + select.Text + " FROM " + Table.Text; //phpbb_users

                //Si il y a une condition on l'ajoute
                if (condition.Text != "" && condition.Text != "Date_programmation")
                {
                    MySQLCmd = MySQLCmd + " WHERE " + condition.Text + " " + oper.Text + " '" + valeur.Text + "'";
                }
                if (condition.Text != "" && condition.Text == "Date_programmation")
                {
                    char[] delimiteurs = new char[] { '/', ' ' };
                    string date = valeur.Text;
                    string[] valdate = date.Split(delimiteurs);
                    string dat = valdate[2]+":" + valdate[1]+":" + valdate[0]+" " +valdate[3];
                    MySQLCmd = MySQLCmd + " WHERE " + condition.Text + " " + oper.Text + " '" + dat + "'";

                }
                // On associe cette requête à la propriété SelectCommand du MySqlDataAdapter
                MyAdapter.SelectCommand = new MySqlCommand(MySQLCmd, Connection);

                // On remplit le dataset avec le résultat de la commande SELECT
                ds.Reset();
                MyAdapter.Fill(ds);

                // On affiche le datagrid
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Refresh();

                // On ferme la connexion le plus tôt possible
                Connection.Close();
            }
            catch (MySqlException Ex)
            {
                Connection.Close();
                MessageBox.Show("Erreur SQL:\n" + Ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Exécution de la requette SQL

        private void Table_SelectedValueChanged(object sender, EventArgs e)
        {
            condition.Items.Clear();
            if (Table.Text == "Programmation")
            {
                condition.Items.Add("Identifiant_programmation");
                condition.Items.Add("Numero_serie");
                condition.Items.Add("Date_programmation");
                condition.Items.Add("Identifiant_operateur");
                condition.Items.Add("Identifiant_produit");
                condition.Items.Add("Identifiant_lieu");
                condition.Items.Add("Nombre_programmation");
            }
            if (Table.Text == "Lieu")
            {
                condition.Items.Add("Identifiant_lieu");
                condition.Items.Add("Localisation");
            }
            if (Table.Text == "Operateur")
            {
                condition.Items.Add("Identifiant_operateur");
                condition.Items.Add("Nom_operateur");
                condition.Items.Add("Prenom_operateur");
                condition.Items.Add("Mot_de_passe");
            }
            if (Table.Text == "Logiciel")
            {
                condition.Items.Add("Identifiant_logiciel");
                condition.Items.Add("Nom_logiciel");
                condition.Items.Add("Version");
                condition.Items.Add("Code_LP");
            }
            if (Table.Text == "Produit")
            {
                condition.Items.Add("Identifiant_produit");
                condition.Items.Add("Nom_produit");
                condition.Items.Add("Code_article");
                condition.Items.Add("Identifiant_logiciel");
                condition.Items.Add("Code_LP");
                condition.Items.Add("Version");
                condition.Items.Add("Image");
                condition.Items.Add("Etat");
            }
        }//Afficher dans la listbox les bons choix en fonction de la table sélectionnée

        private void condition_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ConnnectionStr = String.Empty;

            // On définit la chaine de connexion
            ConnnectionStr = "Database=programmation;Data Source=localhost;User Id=root;Password=";

            Connection.ConnectionString = ConnnectionStr;

            try
            {
                // On ouvre la connexion
                Connection.Open();

                // On définit la requête SELECT à exécuter
                string MySQLCmd = "SELECT DISTINCT " + condition.Text + " FROM " + Table.Text;  //phpbb_users

                // On associe cette requête à la propriété SelectCommand du MySqlDataAdapter
                MyAdapter.SelectCommand = new MySqlCommand(MySQLCmd, Connection);

                // On remplit le dataset avec le résultat de la commande SELECT
                ds.Reset();
                MyAdapter.Fill(ds);

                valeur.Items.Clear();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    valeur.Items.Add(dr[0].ToString());
                }

                // On ferme la connexion le plus tôt possible
                Connection.Close();
            }
            catch (MySqlException Ex)
            {
                Connection.Close();
                MessageBox.Show("Erreur SQL:\n" + Ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Construction de l'instruction SQL

        private void rec_CSV_Click(object sender, EventArgs e)
        {
            myThread = new Thread(new ThreadStart(ThreadLoop));
            myThread.Start();
            progressBar1.Maximum=100000;
            while (myThread.IsAlive)
            {
                progressBar1.Value++;
                if (progressBar1.Value == 100000) progressBar1.Value = 0;
            }
            progressBar1.Value = 99999;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                File.Copy(@"C:\\csvData.csv", @""+folderBrowserDialog1.SelectedPath + "\\export" + DateTime.Now.ToString("yyyyMMddHHmmss")+".csv");
                File.Delete(@"C:\\csvData.csv");
            }
        }//Gestion de la progressbar et lancement du thread

        public void ThreadLoop()
        {             
            string strFilePath = "C:\\csvData.csv";
            StreamWriter sw = new StreamWriter(strFilePath, false);

            int iColCount = ds.Tables[0].Columns.Count;
            for (int i = 0; i < iColCount; i++)
            {
                sw.Write(ds.Tables[0].Columns[i]);
                if (i < iColCount - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);

            foreach (DataRow datr in ds.Tables[0].Rows)
            {
                for (int i = 0; i < iColCount; i++)
                {
                    if (!Convert.IsDBNull(datr[i]))
                    {
                        sw.Write(datr[i].ToString());
                    }
                    if (i < iColCount - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }            
            sw.Close();
            attente = true;
            myThread.Abort();
        }//Thread pour la copie de l'export CSV
    }
}