namespace DP2_MDI
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
            this.tbScore = new System.Windows.Forms.TextBox();
            this.tbNiveau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(212, 301);
            this.btQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(88, 32);
            this.btQuitter.TabIndex = 25;
            this.btQuitter.Text = "QUITTER";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbAvatar.Enabled = false;
            this.pbAvatar.Location = new System.Drawing.Point(158, 153);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(64, 64);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 22;
            this.pbAvatar.TabStop = false;
            // 
            // tbPseudo
            // 
            this.tbPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPseudo.Location = new System.Drawing.Point(77, 117);
            this.tbPseudo.Margin = new System.Windows.Forms.Padding(2);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.ReadOnly = true;
            this.tbPseudo.Size = new System.Drawing.Size(223, 23);
            this.tbPseudo.TabIndex = 21;
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.Location = new System.Drawing.Point(77, 81);
            this.tbMail.Margin = new System.Windows.Forms.Padding(2);
            this.tbMail.Name = "tbMail";
            this.tbMail.ReadOnly = true;
            this.tbMail.Size = new System.Drawing.Size(223, 23);
            this.tbMail.TabIndex = 20;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(77, 46);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.ReadOnly = true;
            this.tbPrenom.Size = new System.Drawing.Size(223, 23);
            this.tbPrenom.TabIndex = 19;
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(77, 13);
            this.tbNom.Margin = new System.Windows.Forms.Padding(2);
            this.tbNom.Name = "tbNom";
            this.tbNom.ReadOnly = true;
            this.tbNom.Size = new System.Drawing.Size(223, 23);
            this.tbNom.TabIndex = 18;
            // 
            // lbAvatar
            // 
            this.lbAvatar.AutoSize = true;
            this.lbAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvatar.Location = new System.Drawing.Point(9, 182);
            this.lbAvatar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAvatar.Name = "lbAvatar";
            this.lbAvatar.Size = new System.Drawing.Size(57, 17);
            this.lbAvatar.TabIndex = 17;
            this.lbAvatar.Text = "Avatar :";
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPseudo.Location = new System.Drawing.Point(9, 119);
            this.lbPseudo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(64, 17);
            this.lbPseudo.TabIndex = 16;
            this.lbPseudo.Text = "Pseudo :";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(9, 83);
            this.lbMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(41, 17);
            this.lbMail.TabIndex = 15;
            this.lbMail.Text = "Mail :";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrenom.Location = new System.Drawing.Point(9, 48);
            this.lbPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(65, 17);
            this.lbPrenom.TabIndex = 14;
            this.lbPrenom.Text = "Prénom :";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(9, 15);
            this.lbNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(45, 17);
            this.lbNom.TabIndex = 13;
            this.lbNom.Text = "Nom :";
            // 
            // tbScore
            // 
            this.tbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbScore.Location = new System.Drawing.Point(78, 264);
            this.tbScore.Margin = new System.Windows.Forms.Padding(2);
            this.tbScore.Name = "tbScore";
            this.tbScore.ReadOnly = true;
            this.tbScore.Size = new System.Drawing.Size(223, 23);
            this.tbScore.TabIndex = 29;
            // 
            // tbNiveau
            // 
            this.tbNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNiveau.Location = new System.Drawing.Point(78, 228);
            this.tbNiveau.Margin = new System.Windows.Forms.Padding(2);
            this.tbNiveau.Name = "tbNiveau";
            this.tbNiveau.ReadOnly = true;
            this.tbNiveau.Size = new System.Drawing.Size(223, 23);
            this.tbNiveau.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Score :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Niveau :";
            // 
            // frmVoirJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(311, 344);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVoirJoueur";
            this.Text = "Voir Joueur";
            this.Load += new System.EventHandler(this.frmVoirJoueur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.TextBox tbNiveau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}