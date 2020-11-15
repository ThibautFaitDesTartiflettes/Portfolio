namespace prj_prosante
{
    partial class FrmVisiteConsulter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteConsulter));
            this.lvVisiteToutes = new System.Windows.Forms.ListView();
            this.colVisiteNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVisiteDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVisiteVisiteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVisiteProfessionnel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVisiteNbProduitsPresentes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colVisiteNbProduitsRetenus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvVisiteToutes
            // 
            this.lvVisiteToutes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colVisiteNumero,
            this.colVisiteDate,
            this.colVisiteVisiteur,
            this.colVisiteProfessionnel,
            this.colVisiteNbProduitsPresentes,
            this.colVisiteNbProduitsRetenus});
            this.lvVisiteToutes.Location = new System.Drawing.Point(157, 57);
            this.lvVisiteToutes.Margin = new System.Windows.Forms.Padding(4);
            this.lvVisiteToutes.Name = "lvVisiteToutes";
            this.lvVisiteToutes.Size = new System.Drawing.Size(1093, 501);
            this.lvVisiteToutes.TabIndex = 0;
            this.lvVisiteToutes.UseCompatibleStateImageBehavior = false;
            this.lvVisiteToutes.View = System.Windows.Forms.View.Details;
            // 
            // colVisiteNumero
            // 
            this.colVisiteNumero.Text = "numVisite";
            // 
            // colVisiteDate
            // 
            this.colVisiteDate.Text = "DateVisite";
            this.colVisiteDate.Width = 100;
            // 
            // colVisiteVisiteur
            // 
            this.colVisiteVisiteur.Text = "Visiteur";
            this.colVisiteVisiteur.Width = 200;
            // 
            // colVisiteProfessionnel
            // 
            this.colVisiteProfessionnel.Text = "Professionnel";
            this.colVisiteProfessionnel.Width = 200;
            // 
            // colVisiteNbProduitsPresentes
            // 
            this.colVisiteNbProduitsPresentes.Text = "NbProduitsPresentes";
            this.colVisiteNbProduitsPresentes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colVisiteNbProduitsRetenus
            // 
            this.colVisiteNbProduitsRetenus.Text = "NbProduitsRetenus";
            this.colVisiteNbProduitsRetenus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.Location = new System.Drawing.Point(567, 580);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(203, 55);
            this.btnFermer.TabIndex = 17;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FrmVisiteConsulter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 688);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lvVisiteToutes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVisiteConsulter";
            this.Text = "Liste des visites";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVisiteConsulter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvVisiteToutes;
        private System.Windows.Forms.ColumnHeader colVisiteNumero;
        private System.Windows.Forms.ColumnHeader colVisiteDate;
        private System.Windows.Forms.ColumnHeader colVisiteVisiteur;
        private System.Windows.Forms.ColumnHeader colVisiteProfessionnel;
        private System.Windows.Forms.ColumnHeader colVisiteNbProduitsPresentes;
        private System.Windows.Forms.ColumnHeader colVisiteNbProduitsRetenus;
        private System.Windows.Forms.Button btnFermer;
    }
}