namespace prj_prosante
{
    partial class FrmVisiteSaisir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteSaisir));
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mcDateVisite = new System.Windows.Forms.MonthCalendar();
            this.cbVisiteur = new System.Windows.Forms.ComboBox();
            this.cbProfessionnel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.udNbProduitsPresentes = new System.Windows.Forms.NumericUpDown();
            this.udNbProduitsRetenus = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udNbProduitsPresentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNbProduitsRetenus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.Location = new System.Drawing.Point(832, 310);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(203, 55);
            this.btnFermer.TabIndex = 23;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Image = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Image")));
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(344, 310);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(203, 55);
            this.btnAjouter.TabIndex = 22;
            this.btnAjouter.Text = "&Ajouter la visite";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(683, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre de produits présentés :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(683, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Visiteur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Date de la visite :";
            // 
            // mcDateVisite
            // 
            this.mcDateVisite.Location = new System.Drawing.Point(293, 32);
            this.mcDateVisite.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mcDateVisite.MaxSelectionCount = 1;
            this.mcDateVisite.Name = "mcDateVisite";
            this.mcDateVisite.TabIndex = 24;
            // 
            // cbVisiteur
            // 
            this.cbVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVisiteur.FormattingEnabled = true;
            this.cbVisiteur.Location = new System.Drawing.Point(823, 32);
            this.cbVisiteur.Margin = new System.Windows.Forms.Padding(4);
            this.cbVisiteur.Name = "cbVisiteur";
            this.cbVisiteur.Size = new System.Drawing.Size(443, 28);
            this.cbVisiteur.TabIndex = 25;
            // 
            // cbProfessionnel
            // 
            this.cbProfessionnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProfessionnel.FormattingEnabled = true;
            this.cbProfessionnel.Location = new System.Drawing.Point(823, 87);
            this.cbProfessionnel.Margin = new System.Windows.Forms.Padding(4);
            this.cbProfessionnel.Name = "cbProfessionnel";
            this.cbProfessionnel.Size = new System.Drawing.Size(443, 28);
            this.cbProfessionnel.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(683, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Professionnel : ";
            // 
            // udNbProduitsPresentes
            // 
            this.udNbProduitsPresentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udNbProduitsPresentes.Location = new System.Drawing.Point(959, 144);
            this.udNbProduitsPresentes.Margin = new System.Windows.Forms.Padding(4);
            this.udNbProduitsPresentes.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.udNbProduitsPresentes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udNbProduitsPresentes.Name = "udNbProduitsPresentes";
            this.udNbProduitsPresentes.Size = new System.Drawing.Size(76, 26);
            this.udNbProduitsPresentes.TabIndex = 28;
            this.udNbProduitsPresentes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udNbProduitsPresentes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udNbProduitsRetenus
            // 
            this.udNbProduitsRetenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udNbProduitsRetenus.Location = new System.Drawing.Point(959, 194);
            this.udNbProduitsRetenus.Margin = new System.Windows.Forms.Padding(4);
            this.udNbProduitsRetenus.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.udNbProduitsRetenus.Name = "udNbProduitsRetenus";
            this.udNbProduitsRetenus.Size = new System.Drawing.Size(76, 26);
            this.udNbProduitsRetenus.TabIndex = 30;
            this.udNbProduitsRetenus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(683, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nombre de produits retenus :";
            // 
            // FrmVisiteSaisir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 731);
            this.Controls.Add(this.udNbProduitsRetenus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.udNbProduitsPresentes);
            this.Controls.Add(this.cbProfessionnel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbVisiteur);
            this.Controls.Add(this.mcDateVisite);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVisiteSaisir";
            this.Text = "Saisie d\'une nouvelle visite";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVisiteSaisir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udNbProduitsPresentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udNbProduitsRetenus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mcDateVisite;
        private System.Windows.Forms.ComboBox cbVisiteur;
        private System.Windows.Forms.ComboBox cbProfessionnel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown udNbProduitsPresentes;
        private System.Windows.Forms.NumericUpDown udNbProduitsRetenus;
        private System.Windows.Forms.Label label5;
    }
}