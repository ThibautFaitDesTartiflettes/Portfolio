namespace prj_prosante
{
    partial class FrmProfessionnelListeVille
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessionnelListeVille));
            this.tbVille = new System.Windows.Forms.TextBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lvProfessionnelVille = new System.Windows.Forms.ListView();
            this.colNomProfessionnel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrenomProfessionnel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpecialiteProfessionnel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVilleProfessionnel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAnneeProfessionnel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(303, 55);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(174, 20);
            this.tbVille.TabIndex = 1;
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.Location = new System.Drawing.Point(303, 451);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(152, 45);
            this.btnFermer.TabIndex = 18;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Image = ((System.Drawing.Image)(resources.GetObject("btnRechercher.Image")));
            this.btnRechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechercher.Location = new System.Drawing.Point(524, 42);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(152, 45);
            this.btnRechercher.TabIndex = 19;
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lvProfessionnelVille
            // 
            this.lvProfessionnelVille.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNomProfessionnel,
            this.colPrenomProfessionnel,
            this.colSpecialiteProfessionnel,
            this.colVilleProfessionnel,
            this.colAnneeProfessionnel});
            this.lvProfessionnelVille.HideSelection = false;
            this.lvProfessionnelVille.Location = new System.Drawing.Point(122, 118);
            this.lvProfessionnelVille.Name = "lvProfessionnelVille";
            this.lvProfessionnelVille.Size = new System.Drawing.Size(522, 269);
            this.lvProfessionnelVille.TabIndex = 20;
            this.lvProfessionnelVille.UseCompatibleStateImageBehavior = false;
            this.lvProfessionnelVille.View = System.Windows.Forms.View.Details;
            // 
            // colNomProfessionnel
            // 
            this.colNomProfessionnel.Text = "Nom";
            this.colNomProfessionnel.Width = 57;
            // 
            // colPrenomProfessionnel
            // 
            this.colPrenomProfessionnel.Text = "Prénom";
            this.colPrenomProfessionnel.Width = 89;
            // 
            // colSpecialiteProfessionnel
            // 
            this.colSpecialiteProfessionnel.Text = "Spécialité";
            this.colSpecialiteProfessionnel.Width = 133;
            // 
            // colVilleProfessionnel
            // 
            this.colVilleProfessionnel.Text = "Ville";
            this.colVilleProfessionnel.Width = 108;
            // 
            // colAnneeProfessionnel
            // 
            this.colAnneeProfessionnel.Text = "Année d\'expérience";
            this.colAnneeProfessionnel.Width = 131;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Saisir la ville voulue :";
            // 
            // FrmProfessionnelListeVille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 568);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvProfessionnelVille);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.tbVille);
            this.Name = "FrmProfessionnelListeVille";
            this.Text = "Liste des professionnels par ville";
            this.Load += new System.EventHandler(this.FrmProfessionnelListeVille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.ListView lvProfessionnelVille;
        private System.Windows.Forms.ColumnHeader colNomProfessionnel;
        private System.Windows.Forms.ColumnHeader colPrenomProfessionnel;
        private System.Windows.Forms.ColumnHeader colSpecialiteProfessionnel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader colVilleProfessionnel;
        private System.Windows.Forms.ColumnHeader colAnneeProfessionnel;
    }
}