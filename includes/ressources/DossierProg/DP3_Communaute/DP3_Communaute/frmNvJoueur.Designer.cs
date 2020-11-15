namespace DP3_Communaute
{
    partial class frmNvJoueur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNvJoueur));
            this.btQuitter = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.btAvatar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(248, 285);
            this.btQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(117, 39);
            this.btQuitter.TabIndex = 25;
            this.btQuitter.Text = "QUITTER";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btValider
            // 
            this.btValider.Enabled = false;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(67, 285);
            this.btValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(117, 39);
            this.btValider.TabIndex = 24;
            this.btValider.Text = "VALIDER";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btAvatar
            // 
            this.btAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAvatar.Location = new System.Drawing.Point(103, 213);
            this.btAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAvatar.Name = "btAvatar";
            this.btAvatar.Size = new System.Drawing.Size(96, 38);
            this.btAvatar.TabIndex = 23;
            this.btAvatar.Text = "Avatar";
            this.btAvatar.UseVisualStyleBackColor = true;
            this.btAvatar.Click += new System.EventHandler(this.btAvatar_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.Enabled = false;
            this.pbAvatar.Location = new System.Drawing.Point(297, 190);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(85, 79);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAvatar.TabIndex = 22;
            this.pbAvatar.TabStop = false;
            // 
            // tbPseudo
            // 
            this.tbPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPseudo.Location = new System.Drawing.Point(103, 143);
            this.tbPseudo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPseudo.Name = "tbPseudo";
            this.tbPseudo.Size = new System.Drawing.Size(320, 27);
            this.tbPseudo.TabIndex = 21;
            this.tbPseudo.TextChanged += new System.EventHandler(this.tbPseudo_TextChanged);
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMail.Location = new System.Drawing.Point(103, 99);
            this.tbMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(320, 27);
            this.tbMail.TabIndex = 20;
            this.tbMail.TextChanged += new System.EventHandler(this.tbMail_TextChanged);
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(103, 56);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(320, 27);
            this.tbPrenom.TabIndex = 19;
            this.tbPrenom.TextChanged += new System.EventHandler(this.tbPrenom_TextChanged);
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(103, 15);
            this.tbNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(320, 27);
            this.tbNom.TabIndex = 18;
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            // 
            // lbAvatar
            // 
            this.lbAvatar.AutoSize = true;
            this.lbAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvatar.Location = new System.Drawing.Point(12, 222);
            this.lbAvatar.Name = "lbAvatar";
            this.lbAvatar.Size = new System.Drawing.Size(67, 20);
            this.lbAvatar.TabIndex = 17;
            this.lbAvatar.Text = "Avatar :";
            // 
            // lbPseudo
            // 
            this.lbPseudo.AutoSize = true;
            this.lbPseudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPseudo.Location = new System.Drawing.Point(12, 146);
            this.lbPseudo.Name = "lbPseudo";
            this.lbPseudo.Size = new System.Drawing.Size(75, 20);
            this.lbPseudo.TabIndex = 16;
            this.lbPseudo.Text = "Pseudo :";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(12, 101);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(50, 20);
            this.lbMail.TabIndex = 15;
            this.lbMail.Text = "Mail :";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrenom.Location = new System.Drawing.Point(12, 60);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(77, 20);
            this.lbPrenom.TabIndex = 14;
            this.lbPrenom.Text = "Prénom :";
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNom.Location = new System.Drawing.Point(12, 18);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(54, 20);
            this.lbNom.TabIndex = 13;
            this.lbNom.Text = "Nom :";
            // 
            // frmNvJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(438, 340);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.btAvatar);
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
            this.Name = "frmNvJoueur";
            this.Text = "Nouveau Joueur";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btAvatar;
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
    }
}