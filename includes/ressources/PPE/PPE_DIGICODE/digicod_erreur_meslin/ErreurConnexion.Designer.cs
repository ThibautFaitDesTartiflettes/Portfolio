namespace digicod_erreur_meslin
{
    partial class ErreurConnexion
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
            this.gbErreur = new System.Windows.Forms.GroupBox();
            this.lvErreur = new System.Windows.Forms.ListView();
            this.clMatricule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clHeure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPorte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbErreur.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbErreur
            // 
            this.gbErreur.Controls.Add(this.lvErreur);
            this.gbErreur.Location = new System.Drawing.Point(12, 12);
            this.gbErreur.Name = "gbErreur";
            this.gbErreur.Size = new System.Drawing.Size(552, 539);
            this.gbErreur.TabIndex = 0;
            this.gbErreur.TabStop = false;
            this.gbErreur.Text = "Liste des erreurs";
            // 
            // lvErreur
            // 
            this.lvErreur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMatricule,
            this.clDate,
            this.clHeure,
            this.clPorte});
            this.lvErreur.FullRowSelect = true;
            this.lvErreur.Location = new System.Drawing.Point(6, 21);
            this.lvErreur.Name = "lvErreur";
            this.lvErreur.Size = new System.Drawing.Size(540, 512);
            this.lvErreur.TabIndex = 0;
            this.lvErreur.UseCompatibleStateImageBehavior = false;
            this.lvErreur.View = System.Windows.Forms.View.Details;
            // 
            // clMatricule
            // 
            this.clMatricule.Text = "Matricule";
            this.clMatricule.Width = 135;
            // 
            // clDate
            // 
            this.clDate.Text = "Date";
            this.clDate.Width = 135;
            // 
            // clHeure
            // 
            this.clHeure.Text = "Heure";
            this.clHeure.Width = 135;
            // 
            // clPorte
            // 
            this.clPorte.Text = "Porte";
            this.clPorte.Width = 135;
            // 
            // ErreurConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 566);
            this.Controls.Add(this.gbErreur);
            this.Name = "ErreurConnexion";
            this.Text = "Erreurs de connexions";
            this.Load += new System.EventHandler(this.ErreurConnexion_Load);
            this.gbErreur.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbErreur;
        private System.Windows.Forms.ListView lvErreur;
        private System.Windows.Forms.ColumnHeader clMatricule;
        private System.Windows.Forms.ColumnHeader clDate;
        private System.Windows.Forms.ColumnHeader clHeure;
        private System.Windows.Forms.ColumnHeader clPorte;
    }
}