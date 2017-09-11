namespace Banc_de_programmation
{
    partial class New_id
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
            this.nv_id = new System.Windows.Forms.TextBox();
            this.nv_nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nv_prenom = new System.Windows.Forms.TextBox();
            this.nv_mdp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.valider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btn_deconnect.BackgroundImage = global::Banc_de_programmation.Properties.Resources.maison1;
            this.btn_deconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deconnect.Location = new System.Drawing.Point(653, 11);
            this.btn_deconnect.Name = "btn_deconnect";
            this.btn_deconnect.Size = new System.Drawing.Size(60, 60);
            this.btn_deconnect.TabIndex = 10;
            this.btn_deconnect.UseVisualStyleBackColor = true;
            this.btn_deconnect.Click += new System.EventHandler(this.btn_deconnect_Click);
            // 
            // nv_id
            // 
            this.nv_id.Location = new System.Drawing.Point(69, 220);
            this.nv_id.Name = "nv_id";
            this.nv_id.Size = new System.Drawing.Size(127, 20);
            this.nv_id.TabIndex = 11;
            // 
            // nv_nom
            // 
            this.nv_nom.Location = new System.Drawing.Point(248, 220);
            this.nv_nom.Name = "nv_nom";
            this.nv_nom.Size = new System.Drawing.Size(127, 20);
            this.nv_nom.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Initiales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nom";
            // 
            // nv_prenom
            // 
            this.nv_prenom.Location = new System.Drawing.Point(429, 220);
            this.nv_prenom.Name = "nv_prenom";
            this.nv_prenom.Size = new System.Drawing.Size(117, 20);
            this.nv_prenom.TabIndex = 15;
            // 
            // nv_mdp
            // 
            this.nv_mdp.Location = new System.Drawing.Point(595, 219);
            this.nv_mdp.Name = "nv_mdp";
            this.nv_mdp.Size = new System.Drawing.Size(119, 20);
            this.nv_mdp.TabIndex = 16;
            this.nv_mdp.Text = "uniquement des chiffres";
            this.nv_mdp.Click += new System.EventHandler(this.nv_mdp_Click);
            this.nv_mdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nv_mdp_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Prenom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(592, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mot de passe";
            // 
            // valider
            // 
            this.valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.Location = new System.Drawing.Point(595, 280);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(119, 35);
            this.valider.TabIndex = 19;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = true;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ajout opérateur";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Banc_de_programmation.Properties.Resources.titre;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_deconnect);
            this.panel1.Controls.Add(this.btn_quit);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 81);
            this.panel1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ajout d\'un opérateur";
            // 
            // New_id
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banc_de_programmation.Properties.Resources.image001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nv_mdp);
            this.Controls.Add(this.nv_prenom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nv_nom);
            this.Controls.Add(this.nv_id);
            this.Name = "New_id";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_deconnect;
        private System.Windows.Forms.TextBox nv_id;
        private System.Windows.Forms.TextBox nv_nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nv_prenom;
        private System.Windows.Forms.TextBox nv_mdp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}