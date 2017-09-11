using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ByteFX.Data.MySqlClient;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;



namespace Banc_de_programmation
{
    public partial class New_id : Form
    {
        private MySqlConnection Connection = new MySqlConnection();
        private MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        private DataSet ds = new DataSet();

        Process proc = new Process();

        public New_id()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;

            proc.StartInfo = new ProcessStartInfo("osk.exe");
            proc.Start();
        }
  
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
        }//Eteint le PC

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
        }//Retour � l'�cran d'accueil

        private void valider_Click(object sender, EventArgs e)
        {
            try
            {
                proc.CloseMainWindow();
            }
            catch
            {
            }
            if (!(nv_id.Text != "" && nv_nom.Text != "" && nv_prenom.Text != "" && nv_mdp.Text != "" && nv_mdp.Text != "uniquement des chiffres"))
            {
                MessageBox.Show("Vous devez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                proc.StartInfo = new ProcessStartInfo("osk.exe");
                proc.Start();
                return;
            }            

            string ConnnectionStr = String.Empty;

            // On d�finit la chaine de connexion
            ConnnectionStr = "Database=programmation;Data Source=localhost;User Id=root;Password=";

            Connection.ConnectionString = ConnnectionStr;

            try
            {
                // Ouverture de la connexion
                Connection.Open();

                // D�finition de la requ�te SELECT � ex�cuter
                string MySQLCmd = "INSERT INTO programmation.operateur(Identifiant_operateur ,Nom_operateur ,Prenom_operateur ,Mot_de_passe) VALUES ('" + nv_id.Text + "', '" + nv_nom.Text + "', '" + nv_prenom.Text + "', '" + nv_mdp.Text + "');";

                // Association cette requ�te � la propri�t� SelectCommand du MySqlDataAdapter
                MyAdapter.SelectCommand = new MySqlCommand(MySQLCmd, Connection);

                // Mise dans le dataset des r�sultats de la commande SELECT
                MyAdapter.Fill(ds);

                // Fermeture de la connexion
                Connection.Close();

                //Message confirmation
                MessageBox.Show("L'op�rateur " + nv_nom.Text + " " + nv_prenom.Text + " a bien �t� ajout�", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                nv_id.Text = "";
                nv_nom.Text = "";
                nv_prenom.Text = "";
                nv_mdp.Text = "uniquement des chiffres";
                proc.StartInfo = new ProcessStartInfo("osk.exe");
                proc.Start();
            }
            catch (MySqlException Ex)
            {
                Connection.Close();
                MessageBox.Show("Erreur SQL:\n" + Ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//Ajout de l'op�rateur dans la base de donn�es

        private void nv_mdp_Click(object sender, EventArgs e)
        {
            if (nv_mdp.Text == "uniquement des chiffres")
            {
                nv_mdp.Text = "";
            }
        }//Indique � l'utilisateur qu'il ne faut entrer que des chiffres

        private void nv_mdp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b'))
            {
                e.Handled = false;
                return;
            }
            if (nv_mdp.Text.Length == 10)
            {
                e.Handled = true;
                return;
            }
            if(char.IsNumber(e.KeyChar))
            {
                if (e.KeyChar == '�') e.Handled = true;
                else e.Handled = false;
            }
            else e.Handled = true;
        }//Emp�che la saisie d'un mot de passe de plus de 10 caract�res NUMERIQUES
    }
}
