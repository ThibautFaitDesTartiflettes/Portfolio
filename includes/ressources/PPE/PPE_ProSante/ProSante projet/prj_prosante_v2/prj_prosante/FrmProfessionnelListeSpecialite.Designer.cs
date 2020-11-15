namespace prj_prosante
{
    partial class FrmProfessionnelListeSpecialite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessionnelListeSpecialite));
            this.tbSpecialiteProfessionnel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lvProfessionnelSpecialisé = new System.Windows.Forms.ListView();
            this.colNomProfessionnel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrenomProfessionnel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSpecialiteProfessionnel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tbSpecialiteProfessionnel
            // 
            this.tbSpecialiteProfessionnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpecialiteProfessionnel.Location = new System.Drawing.Point(259, 24);
            this.tbSpecialiteProfessionnel.Name = "tbSpecialiteProfessionnel";
            this.tbSpecialiteProfessionnel.Size = new System.Drawing.Size(174, 22);
            this.tbSpecialiteProfessionnel.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Saisir la spécialité voulue :";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.Location = new System.Drawing.Point(281, 400);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(152, 45);
            this.btnFermer.TabIndex = 17;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Image = ((System.Drawing.Image)(resources.GetObject("btnRechercher.Image")));
            this.btnRechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechercher.Location = new System.Drawing.Point(484, 12);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(152, 45);
            this.btnRechercher.TabIndex = 18;
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lvProfessionnelSpecialisé
            // 
            this.lvProfessionnelSpecialisé.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNomProfessionnel,
            this.colPrenomProfessionnel,
            this.colSpecialiteProfessionnel});
            this.lvProfessionnelSpecialisé.HideSelection = false;
            this.lvProfessionnelSpecialisé.Location = new System.Drawing.Point(186, 94);
            this.lvProfessionnelSpecialisé.Name = "lvProfessionnelSpecialisé";
            this.lvProfessionnelSpecialisé.Size = new System.Drawing.Size(339, 269);
            this.lvProfessionnelSpecialisé.TabIndex = 19;
            this.lvProfessionnelSpecialisé.UseCompatibleStateImageBehavior = false;
            this.lvProfessionnelSpecialisé.View = System.Windows.Forms.View.Details;
            // 
            // colNomProfessionnel
            // 
            this.colNomProfessionnel.Text = "Nom";
            this.colNomProfessionnel.Width = 90;
            // 
            // colPrenomProfessionnel
            // 
            this.colPrenomProfessionnel.Text = "Prénom";
            this.colPrenomProfessionnel.Width = 130;
            // 
            // colSpecialiteProfessionnel
            // 
            this.colSpecialiteProfessionnel.Text = "Spécialité";
            this.colSpecialiteProfessionnel.Width = 214;
            // 
            // FrmProfessionnelListeSpecialite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 568);
            this.Controls.Add(this.lvProfessionnelSpecialisé);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.tbSpecialiteProfessionnel);
            this.Controls.Add(this.label3);
            this.Name = "FrmProfessionnelListeSpecialite";
            this.Text = "Liste des professionnels par spécialité";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProfessionnelListeSpecialite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSpecialiteProfessionnel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.ListView lvProfessionnelSpecialisé;
        private System.Windows.Forms.ColumnHeader colNomProfessionnel;
        private System.Windows.Forms.ColumnHeader colPrenomProfessionnel;
        private System.Windows.Forms.ColumnHeader colSpecialiteProfessionnel;
    }
}