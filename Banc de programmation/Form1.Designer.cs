namespace Banc_de_programmation
{
    partial class acceuil
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_mdp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mdp_txt = new System.Windows.Forms.Label();
            this.btn_val_id = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.ComboBox();
            this.Ajout_op = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.gerer_produit = new System.Windows.Forms.Button();
            this.gerer_logiciel = new System.Windows.Forms.Button();
            this.consul_BBD = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programmation plate forme électronique";
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mdp.Location = new System.Drawing.Point(276, 283);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(156, 38);
            this.lbl_mdp.TabIndex = 2;
            this.lbl_mdp.UseSystemPasswordChar = true;
            this.lbl_mdp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbl_mdp_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Identifiant";
            // 
            // mdp_txt
            // 
            this.mdp_txt.AutoSize = true;
            this.mdp_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdp_txt.Location = new System.Drawing.Point(60, 285);
            this.mdp_txt.Name = "mdp_txt";
            this.mdp_txt.Size = new System.Drawing.Size(201, 33);
            this.mdp_txt.TabIndex = 4;
            this.mdp_txt.Text = "Mot de passe";
            // 
            // btn_val_id
            // 
            this.btn_val_id.BackColor = System.Drawing.Color.Green;
            this.btn_val_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_val_id.Location = new System.Drawing.Point(677, 386);
            this.btn_val_id.Name = "btn_val_id";
            this.btn_val_id.Size = new System.Drawing.Size(70, 70);
            this.btn_val_id.TabIndex = 5;
            this.btn_val_id.Text = "OK";
            this.btn_val_id.UseVisualStyleBackColor = false;
            this.btn_val_id.Click += new System.EventHandler(this.btn_val_id_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.Transparent;
            this.btn_quit.BackgroundImage = global::Banc_de_programmation.Properties.Resources.quitter1;
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_quit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_quit.Location = new System.Drawing.Point(719, 11);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(60, 60);
            this.btn_quit.TabIndex = 6;
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.FormattingEnabled = true;
            this.lbl_id.Location = new System.Drawing.Point(276, 226);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(156, 39);
            this.lbl_id.TabIndex = 7;
            this.lbl_id.SelectedIndexChanged += new System.EventHandler(this.lbl_id_SelectedIndexChanged);
            // 
            // Ajout_op
            // 
            this.Ajout_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajout_op.Location = new System.Drawing.Point(298, 477);
            this.Ajout_op.Name = "Ajout_op";
            this.Ajout_op.Size = new System.Drawing.Size(134, 48);
            this.Ajout_op.TabIndex = 8;
            this.Ajout_op.Text = "Gestion des opérateur";
            this.Ajout_op.UseVisualStyleBackColor = true;
            this.Ajout_op.Visible = false;
            this.Ajout_op.Click += new System.EventHandler(this.Ajout_op_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(507, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 9;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Clavier_Clic);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(594, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 10;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Clavier_Clic);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(677, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 11;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Clavier_Clic);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(507, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Clavier_Clic);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(594, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 70);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Clavier_Clic);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(677, 226);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Clavier_Clic);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(507, 306);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 15;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Clavier_Clic);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(594, 306);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 70);
            this.button8.TabIndex = 16;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Clavier_Clic);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(677, 306);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 70);
            this.button9.TabIndex = 17;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Clavier_Clic);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(594, 386);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 70);
            this.button10.TabIndex = 18;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Clavier_Clic);
            // 
            // gerer_produit
            // 
            this.gerer_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerer_produit.Location = new System.Drawing.Point(153, 477);
            this.gerer_produit.Name = "gerer_produit";
            this.gerer_produit.Size = new System.Drawing.Size(139, 48);
            this.gerer_produit.TabIndex = 19;
            this.gerer_produit.Text = "Gestion des produits";
            this.gerer_produit.UseVisualStyleBackColor = true;
            this.gerer_produit.Visible = false;
            this.gerer_produit.Click += new System.EventHandler(this.gerer_produit_Click);
            // 
            // gerer_logiciel
            // 
            this.gerer_logiciel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gerer_logiciel.Location = new System.Drawing.Point(8, 477);
            this.gerer_logiciel.Name = "gerer_logiciel";
            this.gerer_logiciel.Size = new System.Drawing.Size(139, 48);
            this.gerer_logiciel.TabIndex = 20;
            this.gerer_logiciel.Text = "Gestion des logiciels";
            this.gerer_logiciel.UseVisualStyleBackColor = true;
            this.gerer_logiciel.Visible = false;
            this.gerer_logiciel.Click += new System.EventHandler(this.gerer_logiciel_Click);
            // 
            // consul_BBD
            // 
            this.consul_BBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consul_BBD.Location = new System.Drawing.Point(438, 477);
            this.consul_BBD.Name = "consul_BBD";
            this.consul_BBD.Size = new System.Drawing.Size(140, 48);
            this.consul_BBD.TabIndex = 21;
            this.consul_BBD.Text = "Consultation de la base de données";
            this.consul_BBD.UseVisualStyleBackColor = true;
            this.consul_BBD.Visible = false;
            this.consul_BBD.Click += new System.EventHandler(this.consul_BBD_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Red;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(507, 386);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(70, 70);
            this.button11.TabIndex = 22;
            this.button11.Text = "C";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Clavier_Clic);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Banc_de_programmation.Properties.Resources.titre;
            this.panel1.Controls.Add(this.btn_quit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 81);
            this.panel1.TabIndex = 23;
            // 
            // acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Banc_de_programmation.Properties.Resources.image001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.consul_BBD);
            this.Controls.Add(this.gerer_logiciel);
            this.Controls.Add(this.gerer_produit);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ajout_op);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_val_id);
            this.Controls.Add(this.mdp_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_mdp);
            this.DoubleBuffered = true;
            this.Name = "acceuil";
            this.Text = "Programmateur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lbl_mdp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label mdp_txt;
        private System.Windows.Forms.Button btn_val_id;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.ComboBox lbl_id;
        private System.Windows.Forms.Button Ajout_op;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button gerer_produit;
        private System.Windows.Forms.Button gerer_logiciel;
        private System.Windows.Forms.Button consul_BBD;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel1;
    }
}

