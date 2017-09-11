namespace Banc_de_programmation
{
    partial class logiciel_à_gérer
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
            this.nv_nom = new System.Windows.Forms.TextBox();
            this.nv_version = new System.Windows.Forms.TextBox();
            this.nv_lp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_deconnect = new System.Windows.Forms.Button();
            this._ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnOuvre = new System.Windows.Forms.Button();
            this.clavier_visuel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nv_nom
            // 
            this.nv_nom.Location = new System.Drawing.Point(98, 205);
            this.nv_nom.Name = "nv_nom";
            this.nv_nom.Size = new System.Drawing.Size(135, 20);
            this.nv_nom.TabIndex = 0;
            // 
            // nv_version
            // 
            this.nv_version.Location = new System.Drawing.Point(536, 205);
            this.nv_version.Name = "nv_version";
            this.nv_version.Size = new System.Drawing.Size(135, 20);
            this.nv_version.TabIndex = 1;
            this.nv_version.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nv_version_KeyPress);
            // 
            // nv_lp
            // 
            this.nv_lp.Location = new System.Drawing.Point(337, 205);
            this.nv_lp.Name = "nv_lp";
            this.nv_lp.Size = new System.Drawing.Size(75, 20);
            this.nv_lp.TabIndex = 2;
            this.nv_lp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nv_lp_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom du logiciel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Version du logiciel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code LP";
            // 
            // btn_valider
            // 
            this.btn_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.Location = new System.Drawing.Point(538, 405);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(134, 34);
            this.btn_valider.TabIndex = 6;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Visible = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.BackgroundImage = global::Banc_de_programmation.Properties.Resources.quitter1;
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quit.Location = new System.Drawing.Point(719, 11);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(60, 60);
            this.btn_quit.TabIndex = 8;
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_deconnect
            // 
            this.btn_deconnect.BackColor = System.Drawing.Color.Transparent;
            this.btn_deconnect.BackgroundImage = global::Banc_de_programmation.Properties.Resources.maison1;
            this.btn_deconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deconnect.Location = new System.Drawing.Point(653, 11);
            this.btn_deconnect.Name = "btn_deconnect";
            this.btn_deconnect.Size = new System.Drawing.Size(60, 60);
            this.btn_deconnect.TabIndex = 11;
            this.btn_deconnect.UseVisualStyleBackColor = false;
            this.btn_deconnect.Click += new System.EventHandler(this.btn_deconnect_Click);
            // 
            // _ofd
            // 
            this._ofd.FileName = "openFileDialog1";
            // 
            // btnOuvre
            // 
            this.btnOuvre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuvre.Location = new System.Drawing.Point(537, 297);
            this.btnOuvre.Name = "btnOuvre";
            this.btnOuvre.Size = new System.Drawing.Size(134, 34);
            this.btnOuvre.TabIndex = 12;
            this.btnOuvre.Text = "Ajout du fichier";
            this.btnOuvre.UseVisualStyleBackColor = true;
            this.btnOuvre.Click += new System.EventHandler(this.btnOuvre_Click);
            // 
            // clavier_visuel
            // 
            this.clavier_visuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clavier_visuel.Location = new System.Drawing.Point(656, 88);
            this.clavier_visuel.Name = "clavier_visuel";
            this.clavier_visuel.Size = new System.Drawing.Size(124, 30);
            this.clavier_visuel.TabIndex = 13;
            this.clavier_visuel.Text = "Clavier visuel";
            this.clavier_visuel.UseVisualStyleBackColor = true;
            this.clavier_visuel.Click += new System.EventHandler(this.clavier_visuel_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Banc_de_programmation.Properties.Resources.titre;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_deconnect);
            this.panel1.Controls.Add(this.btn_quit);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 81);
            this.panel1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ajout d\'un logiciel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(242, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(316, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "LP";
            // 
            // logiciel_à_gérer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banc_de_programmation.Properties.Resources.image001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.clavier_visuel);
            this.Controls.Add(this.btnOuvre);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nv_lp);
            this.Controls.Add(this.nv_version);
            this.Controls.Add(this.nv_nom);
            this.Name = "logiciel_à_gérer";
            this.Text = "Form6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nv_nom;
        private System.Windows.Forms.TextBox nv_version;
        private System.Windows.Forms.TextBox nv_lp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_deconnect;
        private System.Windows.Forms.OpenFileDialog _ofd;
        private System.Windows.Forms.Button btnOuvre;
        private System.Windows.Forms.Button clavier_visuel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}