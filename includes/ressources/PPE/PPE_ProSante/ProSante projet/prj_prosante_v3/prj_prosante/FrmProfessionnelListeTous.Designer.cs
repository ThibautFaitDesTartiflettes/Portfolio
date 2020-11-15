namespace prj_prosante
{
    partial class FrmProfessionnelListeTous
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessionnelListeTous));
            this.lvProfessionnelTous = new System.Windows.Forms.ListView();
            this.colNomProfessionnel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrenomProfessionnel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpecialiteProfessionnel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFermer = new System.Windows.Forms.Button();
            this.Ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Anne = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvProfessionnelTous
            // 
            this.lvProfessionnelTous.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNomProfessionnel,
            this.colPrenomProfessionnel,
            this.colSpecialiteProfessionnel,
            this.Ville,
            this.Anne});
            this.lvProfessionnelTous.HideSelection = false;
            this.lvProfessionnelTous.Location = new System.Drawing.Point(88, 77);
            this.lvProfessionnelTous.Name = "lvProfessionnelTous";
            this.lvProfessionnelTous.Size = new System.Drawing.Size(772, 417);
            this.lvProfessionnelTous.TabIndex = 0;
            this.lvProfessionnelTous.UseCompatibleStateImageBehavior = false;
            this.lvProfessionnelTous.View = System.Windows.Forms.View.Details;
            // 
            // colNomProfessionnel
            // 
            this.colNomProfessionnel.Text = "Nom";
            this.colNomProfessionnel.Width = 150;
            // 
            // colPrenomProfessionnel
            // 
            this.colPrenomProfessionnel.Text = "Prénom";
            this.colPrenomProfessionnel.Width = 150;
            // 
            // colSpecialiteProfessionnel
            // 
            this.colSpecialiteProfessionnel.Text = "Spécialté";
            this.colSpecialiteProfessionnel.Width = 150;
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.Location = new System.Drawing.Point(405, 514);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(152, 45);
            this.btnFermer.TabIndex = 16;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // Ville
            // 
            this.Ville.Text = "Ville";
            // 
            // Anne
            // 
            this.Anne.Text = "Annee";
            // 
            // FrmProfessionnelListeTous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 591);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lvProfessionnelTous);
            this.Name = "FrmProfessionnelListeTous";
            this.Text = "Liste de tous les professionnels";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProfessionnelListeTous_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProfessionnelTous;
        private System.Windows.Forms.ColumnHeader colNomProfessionnel;
        private System.Windows.Forms.ColumnHeader colPrenomProfessionnel;
        private System.Windows.Forms.ColumnHeader colSpecialiteProfessionnel;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.ColumnHeader Ville;
        private System.Windows.Forms.ColumnHeader Anne;
    }
}