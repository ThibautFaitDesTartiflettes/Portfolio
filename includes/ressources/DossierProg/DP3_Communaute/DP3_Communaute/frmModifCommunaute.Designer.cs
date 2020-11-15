namespace DP3_Communaute
{
    partial class frmModifCommunaute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifCommunaute));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btQuitter = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.cbCommunaute = new System.Windows.Forms.ComboBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.btLogo = new System.Windows.Forms.Button();
            this.cbNvFondateur = new System.Windows.Forms.ComboBox();
            this.dtpDateCreation = new System.Windows.Forms.DateTimePicker();
            this.tbDateCreation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFondateur = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbJoueur = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Nouvelle date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Communaute :";
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(319, 444);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(112, 50);
            this.btQuitter.TabIndex = 28;
            this.btQuitter.Text = "QUITTER";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(336, 248);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(96, 84);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 27;
            this.pbLogo.TabStop = false;
            // 
            // cbCommunaute
            // 
            this.cbCommunaute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCommunaute.FormattingEnabled = true;
            this.cbCommunaute.Location = new System.Drawing.Point(206, 16);
            this.cbCommunaute.Name = "cbCommunaute";
            this.cbCommunaute.Size = new System.Drawing.Size(224, 28);
            this.cbCommunaute.TabIndex = 26;
            this.cbCommunaute.SelectedIndexChanged += new System.EventHandler(this.cbCommunaute_SelectedIndexChanged);
            // 
            // tbNom
            // 
            this.tbNom.Enabled = false;
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(208, 111);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(224, 27);
            this.tbNom.TabIndex = 25;
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Logo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nouveau fondateur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nom :";
            // 
            // btValider
            // 
            this.btValider.Enabled = false;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(16, 444);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(112, 50);
            this.btValider.TabIndex = 33;
            this.btValider.Text = "VALIDER";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btLogo
            // 
            this.btLogo.Enabled = false;
            this.btLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogo.Location = new System.Drawing.Point(208, 269);
            this.btLogo.Name = "btLogo";
            this.btLogo.Size = new System.Drawing.Size(79, 43);
            this.btLogo.TabIndex = 34;
            this.btLogo.Text = "Logo";
            this.btLogo.UseVisualStyleBackColor = true;
            this.btLogo.Click += new System.EventHandler(this.btLogo_Click);
            // 
            // cbNvFondateur
            // 
            this.cbNvFondateur.Enabled = false;
            this.cbNvFondateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNvFondateur.FormattingEnabled = true;
            this.cbNvFondateur.Location = new System.Drawing.Point(207, 194);
            this.cbNvFondateur.Name = "cbNvFondateur";
            this.cbNvFondateur.Size = new System.Drawing.Size(224, 28);
            this.cbNvFondateur.TabIndex = 35;
            this.cbNvFondateur.SelectedIndexChanged += new System.EventHandler(this.cbJoueur_SelectedIndexChanged);
            // 
            // dtpDateCreation
            // 
            this.dtpDateCreation.Enabled = false;
            this.dtpDateCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateCreation.Location = new System.Drawing.Point(207, 403);
            this.dtpDateCreation.Name = "dtpDateCreation";
            this.dtpDateCreation.Size = new System.Drawing.Size(225, 22);
            this.dtpDateCreation.TabIndex = 36;
            this.dtpDateCreation.ValueChanged += new System.EventHandler(this.dtpDateCreation_ValueChanged);
            // 
            // tbDateCreation
            // 
            this.tbDateCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDateCreation.Location = new System.Drawing.Point(207, 351);
            this.tbDateCreation.Name = "tbDateCreation";
            this.tbDateCreation.ReadOnly = true;
            this.tbDateCreation.Size = new System.Drawing.Size(225, 27);
            this.tbDateCreation.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 37;
            this.label6.Text = "Date de création :";
            // 
            // tbFondateur
            // 
            this.tbFondateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFondateur.Location = new System.Drawing.Point(207, 151);
            this.tbFondateur.Name = "tbFondateur";
            this.tbFondateur.ReadOnly = true;
            this.tbFondateur.Size = new System.Drawing.Size(224, 27);
            this.tbFondateur.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Fondateur :";
            // 
            // cbJoueur
            // 
            this.cbJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJoueur.FormattingEnabled = true;
            this.cbJoueur.Location = new System.Drawing.Point(207, 59);
            this.cbJoueur.Name = "cbJoueur";
            this.cbJoueur.Size = new System.Drawing.Size(224, 28);
            this.cbJoueur.TabIndex = 42;
            this.cbJoueur.SelectedIndexChanged += new System.EventHandler(this.cbJoueur_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Joueur :";
            // 
            // frmModifCommunaute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(444, 502);
            this.Controls.Add(this.cbJoueur);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbFondateur);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbDateCreation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDateCreation);
            this.Controls.Add(this.cbNvFondateur);
            this.Controls.Add(this.btLogo);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.cbCommunaute);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModifCommunaute";
            this.Text = "Modifier communaute";
            this.Load += new System.EventHandler(this.frmModifCommunaute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ComboBox cbCommunaute;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Button btLogo;
        private System.Windows.Forms.ComboBox cbNvFondateur;
        private System.Windows.Forms.DateTimePicker dtpDateCreation;
        private System.Windows.Forms.TextBox tbDateCreation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFondateur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbJoueur;
        private System.Windows.Forms.Label label8;
    }
}