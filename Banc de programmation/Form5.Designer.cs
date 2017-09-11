namespace Banc_de_programmation
{
    partial class produit_a_gerer
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
            this.comb_prod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radio_actif = new System.Windows.Forms.RadioButton();
            this.radio_obsolete = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.code_lp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.valid_nv = new System.Windows.Forms.Button();
            this.valid_chgt = new System.Windows.Forms.Button();
            this.nom_prod = new System.Windows.Forms.TextBox();
            this.code_arti = new System.Windows.Forms.TextBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.clavier_visuel = new System.Windows.Forms.Button();
            this.actiobso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.image = new System.Windows.Forms.PictureBox();
            this.photo = new System.Windows.Forms.Button();
            this._ofd = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.comb_LP = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Valid_maj_logi = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_quit
            // 
            this.btn_quit.BackgroundImage = global::Banc_de_programmation.Properties.Resources.quitter1;
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quit.Location = new System.Drawing.Point(719, 10);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(60, 60);
            this.btn_quit.TabIndex = 7;
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_deconnect
            // 
            this.btn_deconnect.BackgroundImage = global::Banc_de_programmation.Properties.Resources.maison1;
            this.btn_deconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deconnect.Location = new System.Drawing.Point(653, 10);
            this.btn_deconnect.Name = "btn_deconnect";
            this.btn_deconnect.Size = new System.Drawing.Size(60, 60);
            this.btn_deconnect.TabIndex = 10;
            this.btn_deconnect.UseVisualStyleBackColor = true;
            this.btn_deconnect.Click += new System.EventHandler(this.btn_deconnect_Click);
            // 
            // comb_prod
            // 
            this.comb_prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_prod.FormattingEnabled = true;
            this.comb_prod.Location = new System.Drawing.Point(326, 101);
            this.comb_prod.Name = "comb_prod";
            this.comb_prod.Size = new System.Drawing.Size(113, 28);
            this.comb_prod.TabIndex = 13;
            this.comb_prod.SelectedIndexChanged += new System.EventHandler(this.comb_prod_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Code article";
            // 
            // radio_actif
            // 
            this.radio_actif.AutoSize = true;
            this.radio_actif.BackColor = System.Drawing.Color.Transparent;
            this.radio_actif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_actif.Location = new System.Drawing.Point(326, 155);
            this.radio_actif.Name = "radio_actif";
            this.radio_actif.Size = new System.Drawing.Size(56, 20);
            this.radio_actif.TabIndex = 15;
            this.radio_actif.TabStop = true;
            this.radio_actif.Text = "Actif";
            this.radio_actif.UseVisualStyleBackColor = false;
            this.radio_actif.CheckedChanged += new System.EventHandler(this.radio_actif_CheckedChanged);
            // 
            // radio_obsolete
            // 
            this.radio_obsolete.AutoSize = true;
            this.radio_obsolete.BackColor = System.Drawing.Color.Transparent;
            this.radio_obsolete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_obsolete.Location = new System.Drawing.Point(326, 181);
            this.radio_obsolete.Name = "radio_obsolete";
            this.radio_obsolete.Size = new System.Drawing.Size(89, 20);
            this.radio_obsolete.TabIndex = 16;
            this.radio_obsolete.TabStop = true;
            this.radio_obsolete.Text = "Obsolète";
            this.radio_obsolete.UseVisualStyleBackColor = false;
            this.radio_obsolete.CheckedChanged += new System.EventHandler(this.radio_obsolete_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(464, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nom du produit à ajouter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Code article";
            // 
            // code_lp
            // 
            this.code_lp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.code_lp.FormattingEnabled = true;
            this.code_lp.Location = new System.Drawing.Point(467, 175);
            this.code_lp.Name = "code_lp";
            this.code_lp.Size = new System.Drawing.Size(171, 26);
            this.code_lp.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Code LP";
            // 
            // valid_nv
            // 
            this.valid_nv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valid_nv.Location = new System.Drawing.Point(467, 307);
            this.valid_nv.Name = "valid_nv";
            this.valid_nv.Size = new System.Drawing.Size(171, 32);
            this.valid_nv.TabIndex = 25;
            this.valid_nv.Text = "Valider";
            this.valid_nv.UseVisualStyleBackColor = true;
            this.valid_nv.Click += new System.EventHandler(this.valid_nv_Click);
            // 
            // valid_chgt
            // 
            this.valid_chgt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valid_chgt.Location = new System.Drawing.Point(326, 233);
            this.valid_chgt.Name = "valid_chgt";
            this.valid_chgt.Size = new System.Drawing.Size(113, 32);
            this.valid_chgt.TabIndex = 26;
            this.valid_chgt.Text = "Valider";
            this.valid_chgt.UseVisualStyleBackColor = true;
            this.valid_chgt.Click += new System.EventHandler(this.valid_chgt_Click);
            // 
            // nom_prod
            // 
            this.nom_prod.Location = new System.Drawing.Point(467, 83);
            this.nom_prod.Name = "nom_prod";
            this.nom_prod.Size = new System.Drawing.Size(171, 24);
            this.nom_prod.TabIndex = 27;
            // 
            // code_arti
            // 
            this.code_arti.Location = new System.Drawing.Point(467, 130);
            this.code_arti.Name = "code_arti";
            this.code_arti.Size = new System.Drawing.Size(171, 24);
            this.code_arti.TabIndex = 28;
            this.code_arti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.code_arti_KeyPress);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Location = new System.Drawing.Point(659, 89);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(121, 29);
            this.btn_annuler.TabIndex = 29;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // clavier_visuel
            // 
            this.clavier_visuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clavier_visuel.Location = new System.Drawing.Point(532, 89);
            this.clavier_visuel.Name = "clavier_visuel";
            this.clavier_visuel.Size = new System.Drawing.Size(121, 29);
            this.clavier_visuel.TabIndex = 30;
            this.clavier_visuel.Text = "Clavier visuel";
            this.clavier_visuel.UseVisualStyleBackColor = true;
            this.clavier_visuel.Click += new System.EventHandler(this.clavier_visuel_Click);
            // 
            // actiobso
            // 
            this.actiobso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actiobso.FormattingEnabled = true;
            this.actiobso.Items.AddRange(new object[] {
            "Actif",
            "Obsolète"});
            this.actiobso.Location = new System.Drawing.Point(467, 224);
            this.actiobso.Name = "actiobso";
            this.actiobso.Size = new System.Drawing.Size(171, 26);
            this.actiobso.TabIndex = 31;
            this.actiobso.SelectedIndexChanged += new System.EventHandler(this.actiobso_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Actif / Obsolète";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Banc_de_programmation.Properties.Resources.titre;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btn_deconnect);
            this.panel1.Controls.Add(this.btn_quit);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 81);
            this.panel1.TabIndex = 33;
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(96, 66);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(214, 272);
            this.image.TabIndex = 37;
            this.image.TabStop = false;
            this.image.Visible = false;
            // 
            // photo
            // 
            this.photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photo.Location = new System.Drawing.Point(467, 262);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(171, 33);
            this.photo.TabIndex = 34;
            this.photo.Text = "Ajouter une photo";
            this.photo.UseVisualStyleBackColor = true;
            this.photo.Click += new System.EventHandler(this.photo_Click);
            // 
            // _ofd
            // 
            this._ofd.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(319, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Choix code LP";
            // 
            // comb_LP
            // 
            this.comb_LP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_LP.FormattingEnabled = true;
            this.comb_LP.Location = new System.Drawing.Point(322, 182);
            this.comb_LP.Name = "comb_LP";
            this.comb_LP.Size = new System.Drawing.Size(115, 28);
            this.comb_LP.TabIndex = 38;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 470);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.image);
            this.tabPage1.Controls.Add(this.actiobso);
            this.tabPage1.Controls.Add(this.photo);
            this.tabPage1.Controls.Add(this.code_arti);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nom_prod);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.valid_nv);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.code_lp);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(802, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ajouter un produit";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comb_prod);
            this.tabPage2.Controls.Add(this.radio_actif);
            this.tabPage2.Controls.Add(this.radio_obsolete);
            this.tabPage2.Controls.Add(this.valid_chgt);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actif / Obsolète";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Valid_maj_logi);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.comb_LP);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(802, 437);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mise à jour du logiciel";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(322, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 28);
            this.comboBox1.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Code article";
            // 
            // Valid_maj_logi
            // 
            this.Valid_maj_logi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valid_maj_logi.Location = new System.Drawing.Point(322, 236);
            this.Valid_maj_logi.Name = "Valid_maj_logi";
            this.Valid_maj_logi.Size = new System.Drawing.Size(113, 32);
            this.Valid_maj_logi.TabIndex = 41;
            this.Valid_maj_logi.Text = "Valider";
            this.Valid_maj_logi.UseVisualStyleBackColor = true;
            this.Valid_maj_logi.Click += new System.EventHandler(this.Valid_maj_logi_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 30);
            this.label8.TabIndex = 11;
            this.label8.Text = "Gestion des produits";
            // 
            // produit_a_gerer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banc_de_programmation.Properties.Resources.image001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clavier_visuel);
            this.Controls.Add(this.btn_annuler);
            this.Name = "produit_a_gerer";
            this.Text = "Form5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_deconnect;
        private System.Windows.Forms.ComboBox comb_prod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio_actif;
        private System.Windows.Forms.RadioButton radio_obsolete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox code_lp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button valid_nv;
        private System.Windows.Forms.Button valid_chgt;
        private System.Windows.Forms.TextBox nom_prod;
        private System.Windows.Forms.TextBox code_arti;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button clavier_visuel;
        private System.Windows.Forms.ComboBox actiobso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button photo;
        private System.Windows.Forms.OpenFileDialog _ofd;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comb_LP;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Valid_maj_logi;
        private System.Windows.Forms.Label label6;
    }
}