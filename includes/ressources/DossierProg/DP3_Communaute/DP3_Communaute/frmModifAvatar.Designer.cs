namespace DP3_Communaute
{
    partial class frmModifAvatar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifAvatar));
            this.btAvatar = new System.Windows.Forms.Button();
            this.pbNvAvatar = new System.Windows.Forms.PictureBox();
            this.pbActAvatar = new System.Windows.Forms.PictureBox();
            this.btQuitter = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.cbJoueur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNvAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btAvatar
            // 
            this.btAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAvatar.Location = new System.Drawing.Point(176, 173);
            this.btAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAvatar.Name = "btAvatar";
            this.btAvatar.Size = new System.Drawing.Size(96, 38);
            this.btAvatar.TabIndex = 53;
            this.btAvatar.Text = "Avatar";
            this.btAvatar.UseVisualStyleBackColor = true;
            this.btAvatar.Click += new System.EventHandler(this.btAvatar_Click);
            // 
            // pbNvAvatar
            // 
            this.pbNvAvatar.Enabled = false;
            this.pbNvAvatar.Location = new System.Drawing.Point(293, 157);
            this.pbNvAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbNvAvatar.Name = "pbNvAvatar";
            this.pbNvAvatar.Size = new System.Drawing.Size(85, 79);
            this.pbNvAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNvAvatar.TabIndex = 52;
            this.pbNvAvatar.TabStop = false;
            // 
            // pbActAvatar
            // 
            this.pbActAvatar.Enabled = false;
            this.pbActAvatar.Location = new System.Drawing.Point(293, 55);
            this.pbActAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbActAvatar.Name = "pbActAvatar";
            this.pbActAvatar.Size = new System.Drawing.Size(85, 79);
            this.pbActAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbActAvatar.TabIndex = 51;
            this.pbActAvatar.TabStop = false;
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(205, 254);
            this.btQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(117, 39);
            this.btQuitter.TabIndex = 50;
            this.btQuitter.Text = "QUITTER";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btValider
            // 
            this.btValider.Enabled = false;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(40, 254);
            this.btValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(117, 39);
            this.btValider.TabIndex = 49;
            this.btValider.Text = "VALIDER";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nouveau avatar :";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(8, 87);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(117, 20);
            this.lbMail.TabIndex = 47;
            this.lbMail.Text = "Avatar actuel :";
            // 
            // cbJoueur
            // 
            this.cbJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJoueur.FormattingEnabled = true;
            this.cbJoueur.Location = new System.Drawing.Point(100, 12);
            this.cbJoueur.Name = "cbJoueur";
            this.cbJoueur.Size = new System.Drawing.Size(276, 28);
            this.cbJoueur.TabIndex = 55;
            this.cbJoueur.SelectedIndexChanged += new System.EventHandler(this.cbJoueur_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Joueur :";
            // 
            // frmModifAvatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(388, 310);
            this.Controls.Add(this.cbJoueur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btAvatar);
            this.Controls.Add(this.pbNvAvatar);
            this.Controls.Add(this.pbActAvatar);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmModifAvatar";
            this.Text = "Modifier avatar";
            this.Load += new System.EventHandler(this.frmModifAvatar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNvAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbActAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAvatar;
        private System.Windows.Forms.PictureBox pbNvAvatar;
        private System.Windows.Forms.PictureBox pbActAvatar;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.ComboBox cbJoueur;
        private System.Windows.Forms.Label label3;
    }
}