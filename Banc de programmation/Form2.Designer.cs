namespace Banc_de_programmation
{
    partial class programmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(programmation));
            this.btn_deconnect = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comb_prod = new System.Windows.Forms.ComboBox();
            this.lbl_n_serie = new System.Windows.Forms.TextBox();
            this.lbl_LP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_nv_lot = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.photo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_n_lot = new System.Windows.Forms.Label();
            this.lbl_lieu = new System.Windows.Forms.Label();
            this.lbl_id_op = new System.Windows.Forms.Label();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.new_print = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.version_2 = new System.Windows.Forms.Label();
            this.n_serie_2 = new System.Windows.Forms.Label();
            this.LP_2 = new System.Windows.Forms.Label();
            this.code_article2 = new System.Windows.Forms.Label();
            this.nv_imp = new System.Windows.Forms.Panel();
            this.btn_trsf = new System.Windows.Forms.Button();
            this.panel_etik1 = new System.Windows.Forms.Panel();
            this.version = new System.Windows.Forms.Label();
            this.n_serie = new System.Windows.Forms.Label();
            this.code_article = new System.Windows.Forms.Label();
            this.LP = new System.Windows.Forms.Label();
            this.validation = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.erreur = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.nv_imp.SuspendLayout();
            this.panel_etik1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_deconnect
            // 
            this.btn_deconnect.BackgroundImage = global::Banc_de_programmation.Properties.Resources.maison1;
            this.btn_deconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deconnect.Location = new System.Drawing.Point(653, 12);
            this.btn_deconnect.Name = "btn_deconnect";
            this.btn_deconnect.Size = new System.Drawing.Size(60, 60);
            this.btn_deconnect.TabIndex = 8;
            this.btn_deconnect.UseVisualStyleBackColor = true;
            this.btn_deconnect.Click += new System.EventHandler(this.btn_deconnect_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.BackgroundImage = global::Banc_de_programmation.Properties.Resources.quitter1;
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quit.Location = new System.Drawing.Point(719, 12);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(60, 60);
            this.btn_quit.TabIndex = 7;
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Code article";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(55, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Opérateur";
            // 
            // comb_prod
            // 
            this.comb_prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comb_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_prod.FormattingEnabled = true;
            this.comb_prod.Location = new System.Drawing.Point(152, 158);
            this.comb_prod.Name = "comb_prod";
            this.comb_prod.Size = new System.Drawing.Size(119, 33);
            this.comb_prod.TabIndex = 17;
            this.comb_prod.SelectedValueChanged += new System.EventHandler(this.comb_prod_SelectedValueChanged);
            // 
            // lbl_n_serie
            // 
            this.lbl_n_serie.BackColor = System.Drawing.Color.White;
            this.lbl_n_serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n_serie.Location = new System.Drawing.Point(21, 158);
            this.lbl_n_serie.Name = "lbl_n_serie";
            this.lbl_n_serie.ReadOnly = true;
            this.lbl_n_serie.Size = new System.Drawing.Size(65, 31);
            this.lbl_n_serie.TabIndex = 18;
            this.lbl_n_serie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_LP
            // 
            this.lbl_LP.BackColor = System.Drawing.Color.White;
            this.lbl_LP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LP.Location = new System.Drawing.Point(343, 160);
            this.lbl_LP.Name = "lbl_LP";
            this.lbl_LP.ReadOnly = true;
            this.lbl_LP.Size = new System.Drawing.Size(108, 31);
            this.lbl_LP.TabIndex = 20;
            this.lbl_LP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Code LP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "N° ordre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(386, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "N° lot";
            // 
            // btn_nv_lot
            // 
            this.btn_nv_lot.BackColor = System.Drawing.Color.White;
            this.btn_nv_lot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nv_lot.Location = new System.Drawing.Point(391, 40);
            this.btn_nv_lot.Name = "btn_nv_lot";
            this.btn_nv_lot.Size = new System.Drawing.Size(139, 32);
            this.btn_nv_lot.TabIndex = 26;
            this.btn_nv_lot.Text = "Nouveau lot";
            this.btn_nv_lot.UseVisualStyleBackColor = false;
            this.btn_nv_lot.Click += new System.EventHandler(this.btn_nv_lot_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(55, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Lieu";
            // 
            // photo
            // 
            this.photo.BackColor = System.Drawing.Color.Transparent;
            this.photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photo.Location = new System.Drawing.Point(593, 122);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(170, 215);
            this.photo.TabIndex = 33;
            this.photo.TabStop = false;
            this.photo.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Banc_de_programmation.Properties.Resources.titre;
            this.panel1.Controls.Add(this.lbl_n_lot);
            this.panel1.Controls.Add(this.lbl_lieu);
            this.panel1.Controls.Add(this.lbl_id_op);
            this.panel1.Controls.Add(this.btn_deconnect);
            this.panel1.Controls.Add(this.btn_quit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_nv_lot);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 81);
            this.panel1.TabIndex = 34;
            // 
            // lbl_n_lot
            // 
            this.lbl_n_lot.AutoSize = true;
            this.lbl_n_lot.BackColor = System.Drawing.Color.Transparent;
            this.lbl_n_lot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n_lot.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_n_lot.Location = new System.Drawing.Point(467, 12);
            this.lbl_n_lot.Name = "lbl_n_lot";
            this.lbl_n_lot.Size = new System.Drawing.Size(70, 25);
            this.lbl_n_lot.TabIndex = 31;
            this.lbl_n_lot.Text = "label7";
            // 
            // lbl_lieu
            // 
            this.lbl_lieu.AutoSize = true;
            this.lbl_lieu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lieu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_lieu.Location = new System.Drawing.Point(173, 47);
            this.lbl_lieu.Name = "lbl_lieu";
            this.lbl_lieu.Size = new System.Drawing.Size(39, 25);
            this.lbl_lieu.TabIndex = 30;
            this.lbl_lieu.Text = "BZ";
            // 
            // lbl_id_op
            // 
            this.lbl_id_op.AutoSize = true;
            this.lbl_id_op.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_op.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_id_op.Location = new System.Drawing.Point(173, 12);
            this.lbl_id_op.Name = "lbl_id_op";
            this.lbl_id_op.Size = new System.Drawing.Size(217, 25);
            this.lbl_id_op.TabIndex = 29;
            this.lbl_id_op.Text = "intiales de l\'opérateur";
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // new_print
            // 
            this.new_print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("new_print.BackgroundImage")));
            this.new_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.new_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_print.Location = new System.Drawing.Point(318, 34);
            this.new_print.Name = "new_print";
            this.new_print.Size = new System.Drawing.Size(139, 84);
            this.new_print.TabIndex = 31;
            this.new_print.Text = "Ré-impression";
            this.new_print.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.new_print.UseVisualStyleBackColor = true;
            this.new_print.Visible = false;
            this.new_print.Click += new System.EventHandler(this.new_print_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.version_2);
            this.panel2.Controls.Add(this.n_serie_2);
            this.panel2.Controls.Add(this.LP_2);
            this.panel2.Controls.Add(this.code_article2);
            this.panel2.Location = new System.Drawing.Point(24, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 84);
            this.panel2.TabIndex = 36;
            // 
            // version_2
            // 
            this.version_2.AutoSize = true;
            this.version_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version_2.Location = new System.Drawing.Point(153, 48);
            this.version_2.Name = "version_2";
            this.version_2.Size = new System.Drawing.Size(91, 29);
            this.version_2.TabIndex = 3;
            this.version_2.Text = "version";
            // 
            // n_serie_2
            // 
            this.n_serie_2.AutoSize = true;
            this.n_serie_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_serie_2.Location = new System.Drawing.Point(3, 48);
            this.n_serie_2.Name = "n_serie_2";
            this.n_serie_2.Size = new System.Drawing.Size(94, 29);
            this.n_serie_2.TabIndex = 2;
            this.n_serie_2.Text = "n° série";
            // 
            // LP_2
            // 
            this.LP_2.AutoSize = true;
            this.LP_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LP_2.Location = new System.Drawing.Point(125, 8);
            this.LP_2.Name = "LP_2";
            this.LP_2.Size = new System.Drawing.Size(42, 29);
            this.LP_2.TabIndex = 1;
            this.LP_2.Text = "LP";
            // 
            // code_article2
            // 
            this.code_article2.AutoSize = true;
            this.code_article2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_article2.Location = new System.Drawing.Point(2, 8);
            this.code_article2.Name = "code_article2";
            this.code_article2.Size = new System.Drawing.Size(72, 29);
            this.code_article2.TabIndex = 0;
            this.code_article2.Text = "Code";
            // 
            // nv_imp
            // 
            this.nv_imp.BackColor = System.Drawing.Color.Transparent;
            this.nv_imp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nv_imp.Controls.Add(this.panel2);
            this.nv_imp.Controls.Add(this.new_print);
            this.nv_imp.Location = new System.Drawing.Point(1, 456);
            this.nv_imp.Name = "nv_imp";
            this.nv_imp.Size = new System.Drawing.Size(801, 154);
            this.nv_imp.TabIndex = 37;
            this.nv_imp.Visible = false;
            // 
            // btn_trsf
            // 
            this.btn_trsf.BackgroundImage = global::Banc_de_programmation.Properties.Resources.fleche_verte_droite;
            this.btn_trsf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_trsf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trsf.Location = new System.Drawing.Point(315, 253);
            this.btn_trsf.Name = "btn_trsf";
            this.btn_trsf.Size = new System.Drawing.Size(139, 85);
            this.btn_trsf.TabIndex = 16;
            this.btn_trsf.Text = "Programmation";
            this.btn_trsf.UseVisualStyleBackColor = true;
            this.btn_trsf.Visible = false;
            this.btn_trsf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_trsf_MouseDown);
            this.btn_trsf.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_trsf_MouseUp);
            // 
            // panel_etik1
            // 
            this.panel_etik1.BackColor = System.Drawing.Color.White;
            this.panel_etik1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_etik1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_etik1.Controls.Add(this.version);
            this.panel_etik1.Controls.Add(this.n_serie);
            this.panel_etik1.Controls.Add(this.code_article);
            this.panel_etik1.Controls.Add(this.LP);
            this.panel_etik1.Location = new System.Drawing.Point(21, 254);
            this.panel_etik1.Name = "panel_etik1";
            this.panel_etik1.Size = new System.Drawing.Size(250, 84);
            this.panel_etik1.TabIndex = 35;
            this.panel_etik1.Visible = false;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(153, 47);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(0, 29);
            this.version.TabIndex = 3;
            // 
            // n_serie
            // 
            this.n_serie.AutoSize = true;
            this.n_serie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_serie.Location = new System.Drawing.Point(3, 47);
            this.n_serie.Name = "n_serie";
            this.n_serie.Size = new System.Drawing.Size(0, 29);
            this.n_serie.TabIndex = 2;
            // 
            // code_article
            // 
            this.code_article.AutoSize = true;
            this.code_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_article.Location = new System.Drawing.Point(3, 5);
            this.code_article.Name = "code_article";
            this.code_article.Size = new System.Drawing.Size(0, 29);
            this.code_article.TabIndex = 1;
            // 
            // LP
            // 
            this.LP.AutoSize = true;
            this.LP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LP.Location = new System.Drawing.Point(126, 5);
            this.LP.Name = "LP";
            this.LP.Size = new System.Drawing.Size(0, 29);
            this.LP.TabIndex = 0;
            // 
            // validation
            // 
            this.validation.BackgroundImage = global::Banc_de_programmation.Properties.Resources.validation;
            this.validation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.validation.Location = new System.Drawing.Point(488, 254);
            this.validation.Name = "validation";
            this.validation.Size = new System.Drawing.Size(84, 84);
            this.validation.TabIndex = 29;
            this.validation.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(315, 334);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(139, 22);
            this.progressBar1.TabIndex = 38;
            this.progressBar1.Visible = false;
            // 
            // erreur
            // 
            this.erreur.BackgroundImage = global::Banc_de_programmation.Properties.Resources.erreur;
            this.erreur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.erreur.Location = new System.Drawing.Point(483, 253);
            this.erreur.Name = "erreur";
            this.erreur.Size = new System.Drawing.Size(86, 85);
            this.erreur.TabIndex = 0;
            this.erreur.Visible = false;
            // 
            // programmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banc_de_programmation.Properties.Resources.image001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.erreur);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.nv_imp);
            this.Controls.Add(this.validation);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.panel_etik1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_LP);
            this.Controls.Add(this.lbl_n_serie);
            this.Controls.Add(this.comb_prod);
            this.Controls.Add(this.btn_trsf);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(3)));
            this.Name = "programmation";
            this.Text = "Programmateur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.nv_imp.ResumeLayout(false);
            this.panel_etik1.ResumeLayout(false);
            this.panel_etik1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_deconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comb_prod;
        private System.Windows.Forms.TextBox lbl_n_serie;
        private System.Windows.Forms.TextBox lbl_LP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_nv_lot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_lieu;
        private System.Windows.Forms.Label lbl_id_op;
        private System.Windows.Forms.Label lbl_n_lot;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.Button new_print;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label version_2;
        private System.Windows.Forms.Label n_serie_2;
        private System.Windows.Forms.Label LP_2;
        private System.Windows.Forms.Label code_article2;
        private System.Windows.Forms.Panel nv_imp;
        private System.Windows.Forms.Button btn_trsf;
        private System.Windows.Forms.Panel panel_etik1;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label n_serie;
        private System.Windows.Forms.Label code_article;
        private System.Windows.Forms.Label LP;
        private System.Windows.Forms.Panel validation;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel erreur;
    }
}