namespace DP3_Communaute
{
    partial class frmVoirJoueur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoirJoueur));
            this.tbScore = new System.Windows.Forms.TextBox();
            this.tbNiveau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btQuitter = new System.Windows.Forms.Button();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.tbPseudo = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lbAvatar = new System.Windows.Forms.Label();
            this.lbPseudo = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.lbNom = new System.Windows.Forms.Label();
            this.cbJoueur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCommunaute = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbScore
            // 
            this.tbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScore.Location = new System.Drawing.Point(151, 365);
            this.tbScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbScore.Name = "tbScore";
            this.tbScore.ReadOnly = true;
            this.tbScore.Size = new System.Drawing.Size(296, 27);
            this.tbScore.TabIndex = 44;
            // 
            // tbNiveau
            // 
            this.tbNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNiveau.Location = new System.Drawing.Point(151, 321);
            this.tbNiveau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNiveau.Name = "tbNiveau";
            this.tbNiveau.ReadOnly = true;
            this.tbNiveau.Size = new System.Drawing.Size(296, 27);
            this.tbNiveau.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Score :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Niveau :";
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(330, 450);
            this.btQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(117, 39);
            this.btQuitter.TabIndex = 40;
            this.btQuitter.Text = "QUITTER";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAvatar.Enabled = false;
            this.pbAvatar.Location = new System.Drawing.Point(258, 228);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(85, 78);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 39;
            this.pbAvatar.TabStop = false;
            // 
            // tbPseudo
            // 
            this.tbPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPseudo.Location = new System.Drawing.Point(150, 184);
            this.tbPseudo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.ReadOnly = true;
            this.tbPseudo.Size = new System.Drawing.Size(296, 27);
            this.tbPseudo.TabIndex = 38;
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.Location = new System.Drawing.Point(150, 140);
            this.tbMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMail.Name = "tbMail";
            this.tbMail.ReadOnly = true;
            this.tbMail.Size = new System.Drawing.Size(296, 27);
            this.tbMail.TabIndex = 37;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(150, 97);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.ReadOnly = true;
            this.tbPrenom.Size = new System.Drawing.Size(296, 27);
            this.tbPrenom.TabIndex = 36;
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(150, 56);
            this.tbNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNom.Name = "tbNom";
            this.tbNom.ReadOnly = true;
            this.tbNom.Size = new System.Drawing.Size(296, 27);
            this.tbNom.TabIndex = 35;
            // 
            // lbAvatar
            // 
            this.lbAvatar.AutoSize = true;
            this.lbAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvatar.Location = new System.Drawing.Point(12, 264);
            this.lbAvatar.Name = "lbAvatar";
            this.lbAvatar.Size = new System.Drawing.Size(67, 20);
            this.lbAvatar.TabIndex = 34;
            this.lbAvatar.Text = "Avatar :";
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPseudo.Location = new System.Drawing.Point(12, 186);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(75, 20);
            this.lbPseudo.TabIndex = 33;
            this.lbPseudo.Text = "Pseudo :";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(12, 142);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(50, 20);
            this.lbMail.TabIndex = 32;
            this.lbMail.Text = "Mail :";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrenom.Location = new System.Drawing.Point(12, 99);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(77, 20);
            this.lbPrenom.TabIndex = 31;
            this.lbPrenom.Text = "Prénom :";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(12, 58);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(54, 20);
            this.lbNom.TabIndex = 30;
            this.lbNom.Text = "Nom :";
            // 
            // cbJoueur
            // 
            this.cbJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJoueur.FormattingEnabled = true;
            this.cbJoueur.Location = new System.Drawing.Point(150, 12);
            this.cbJoueur.Name = "cbJoueur";
            this.cbJoueur.Size = new System.Drawing.Size(296, 28);
            this.cbJoueur.TabIndex = 46;
            this.cbJoueur.SelectedIndexChanged += new System.EventHandler(this.cbJoueur_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Joueur :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbCommunaute
            // 
            this.tbCommunaute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCommunaute.Location = new System.Drawing.Point(150, 408);
            this.tbCommunaute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCommunaute.Name = "tbCommunaute";
            this.tbCommunaute.ReadOnly = true;
            this.tbCommunaute.Size = new System.Drawing.Size(297, 27);
            this.tbCommunaute.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Communauté :";
            // 
            // frmVoirJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(458, 500);
            this.Controls.Add(this.tbCommunaute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbJoueur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbScore);
            this.Controls.Add(this.tbNiveau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.tbPseudo);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbAvatar);
            this.Controls.Add(this.lbPseudo);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.lbPrenom);
            this.Controls.Add(this.lbNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVoirJoueur";
            this.Text = "Voir Joueur";
            this.Load += new System.EventHandler(this.frmVoirJoueur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.TextBox tbNiveau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.TextBox tbPseudo;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lbAvatar;
        private System.Windows.Forms.Label lbPseudo;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.ComboBox cbJoueur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCommunaute;
        private System.Windows.Forms.Label label4;
    }
}