namespace DP3_Communaute
{
    partial class frmClassementJoueurCommunaute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassementJoueurCommunaute));
            this.lvClassement = new System.Windows.Forms.ListView();
            this.clPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPseudo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clIdentite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNiveau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCommunaute = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lvClassement
            // 
            this.lvClassement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clPosition,
            this.clPseudo,
            this.clIdentite,
            this.clNiveau,
            this.clScore});
            this.lvClassement.Location = new System.Drawing.Point(12, 12);
            this.lvClassement.Name = "lvClassement";
            this.lvClassement.Size = new System.Drawing.Size(776, 353);
            this.lvClassement.TabIndex = 0;
            this.lvClassement.UseCompatibleStateImageBehavior = false;
            this.lvClassement.View = System.Windows.Forms.View.Details;
            // 
            // clPosition
            // 
            this.clPosition.Text = "Position";
            this.clPosition.Width = 100;
            // 
            // clPseudo
            // 
            this.clPseudo.Text = "Pseudo";
            this.clPseudo.Width = 150;
            // 
            // clIdentite
            // 
            this.clIdentite.Text = "Identité";
            this.clIdentite.Width = 150;
            // 
            // clNiveau
            // 
            this.clNiveau.Text = "Niveau";
            this.clNiveau.Width = 100;
            // 
            // clScore
            // 
            this.clScore.Text = "Score";
            this.clScore.Width = 100;
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(670, 371);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(118, 47);
            this.btQuitter.TabIndex = 1;
            this.btQuitter.Text = "QUITTER";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Communaute :";
            // 
            // cbCommunaute
            // 
            this.cbCommunaute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCommunaute.FormattingEnabled = true;
            this.cbCommunaute.Location = new System.Drawing.Point(145, 381);
            this.cbCommunaute.Name = "cbCommunaute";
            this.cbCommunaute.Size = new System.Drawing.Size(216, 28);
            this.cbCommunaute.TabIndex = 3;
            this.cbCommunaute.SelectedIndexChanged += new System.EventHandler(this.cbCommunaute_SelectedIndexChanged);
            // 
            // frmClassementJoueurCommunaute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.cbCommunaute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.lvClassement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClassementJoueurCommunaute";
            this.Text = "Classement de la communauté";
            this.Load += new System.EventHandler(this.frmClassementJoueurCommunaute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvClassement;
        private System.Windows.Forms.ColumnHeader clPosition;
        private System.Windows.Forms.ColumnHeader clPseudo;
        private System.Windows.Forms.ColumnHeader clIdentite;
        private System.Windows.Forms.ColumnHeader clNiveau;
        private System.Windows.Forms.ColumnHeader clScore;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCommunaute;
    }
}