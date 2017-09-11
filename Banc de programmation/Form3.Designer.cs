namespace Banc_de_programmation
{
    partial class base_donnees
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_deconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Table = new System.Windows.Forms.ComboBox();
            this.select = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oper = new System.Windows.Forms.ComboBox();
            this.rec_CSV = new System.Windows.Forms.Button();
            this.condition = new System.Windows.Forms.ComboBox();
            this.valeur = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_quit
            // 
            this.btn_quit.BackgroundImage = global::Banc_de_programmation.Properties.Resources.quitter1;
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quit.Location = new System.Drawing.Point(718, 10);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(60, 60);
            this.btn_quit.TabIndex = 7;
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click_1);
            // 
            // btn_deconnect
            // 
            this.btn_deconnect.BackgroundImage = global::Banc_de_programmation.Properties.Resources.maison1;
            this.btn_deconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deconnect.Location = new System.Drawing.Point(649, 10);
            this.btn_deconnect.Name = "btn_deconnect";
            this.btn_deconnect.Size = new System.Drawing.Size(60, 60);
            this.btn_deconnect.TabIndex = 9;
            this.btn_deconnect.UseVisualStyleBackColor = true;
            this.btn_deconnect.Click += new System.EventHandler(this.btn_deconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Interrogation base de données";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(189, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Table à interroger  (FROM)";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(655, 120);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(113, 26);
            this.btn_valider.TabIndex = 13;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(768, 316);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Visible = false;
            // 
            // Table
            // 
            this.Table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Table.FormattingEnabled = true;
            this.Table.Items.AddRange(new object[] {
            "Produit",
            "Logiciel",
            "Programmation",
            "Operateur",
            "Lieu"});
            this.Table.Location = new System.Drawing.Point(192, 123);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(153, 21);
            this.Table.TabIndex = 15;
            this.Table.SelectedValueChanged += new System.EventHandler(this.Table_SelectedValueChanged);
            // 
            // select
            // 
            this.select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select.FormattingEnabled = true;
            this.select.Items.AddRange(new object[] {
            "*",
            "Identifiant_lieu",
            "Localisation",
            "Identifiant_logiciel",
            "Nom_logiciel",
            "Code_LP",
            "Version",
            "Identifiant_operateur",
            "Nom_operateur",
            "Prenom_operateur",
            "Mot_de_passe",
            "Identifiant_produit",
            "Nom_produit",
            "Code_article",
            "Etat",
            "Identifiant_programmation",
            "Date_programmation",
            "Numero_serie"});
            this.select.Location = new System.Drawing.Point(20, 122);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(153, 21);
            this.select.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(17, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Valeur à afficher  (SELECT)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(352, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Condition  (WHERE)";
            // 
            // oper
            // 
            this.oper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oper.FormattingEnabled = true;
            this.oper.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            "<=",
            ">=",
            "!="});
            this.oper.Location = new System.Drawing.Point(486, 123);
            this.oper.Name = "oper";
            this.oper.Size = new System.Drawing.Size(41, 21);
            this.oper.TabIndex = 21;
            // 
            // rec_CSV
            // 
            this.rec_CSV.Enabled = false;
            this.rec_CSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec_CSV.Location = new System.Drawing.Point(12, 502);
            this.rec_CSV.Name = "rec_CSV";
            this.rec_CSV.Size = new System.Drawing.Size(154, 42);
            this.rec_CSV.TabIndex = 23;
            this.rec_CSV.Text = "Export CSV";
            this.rec_CSV.UseVisualStyleBackColor = true;
            this.rec_CSV.Click += new System.EventHandler(this.rec_CSV_Click);
            // 
            // condition
            // 
            this.condition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.condition.FormattingEnabled = true;
            this.condition.Location = new System.Drawing.Point(355, 123);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(125, 21);
            this.condition.TabIndex = 24;
            this.condition.SelectedIndexChanged += new System.EventHandler(this.condition_SelectedIndexChanged);
            // 
            // valeur
            // 
            this.valeur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.valeur.FormattingEnabled = true;
            this.valeur.Location = new System.Drawing.Point(534, 123);
            this.valeur.Name = "valeur";
            this.valeur.Size = new System.Drawing.Size(112, 21);
            this.valeur.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Banc_de_programmation.Properties.Resources.titre;
            this.panel1.Controls.Add(this.btn_deconnect);
            this.panel1.Controls.Add(this.btn_quit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 81);
            this.panel1.TabIndex = 28;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(190, 291);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(414, 28);
            this.progressBar1.TabIndex = 29;
            this.progressBar1.Visible = false;
            // 
            // base_donnees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banc_de_programmation.Properties.Resources.image001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.valeur);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.rec_CSV);
            this.Controls.Add(this.oper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.select);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label2);
            this.Name = "base_donnees";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_deconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox Table;
        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox oper;
        private System.Windows.Forms.Button rec_CSV;
        private System.Windows.Forms.ComboBox condition;
        private System.Windows.Forms.ComboBox valeur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}