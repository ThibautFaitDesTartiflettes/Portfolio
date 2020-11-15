namespace prj_prosante
{
    partial class FrmVisiteStatistiques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteStatistiques));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAfficherNbVisitesSpecialite = new System.Windows.Forms.Button();
            this.tbNbVisitesSpecialite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSpecialite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbVisiteur = new System.Windows.Forms.ComboBox();
            this.btnAfficherNbVisitesVisiteur = new System.Windows.Forms.Button();
            this.tbNbVisitesVisiteur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbProfessionnel = new System.Windows.Forms.ComboBox();
            this.btnAfficherNbVisitesProfessionnel = new System.Windows.Forms.Button();
            this.tbNbVisitesProfessionnel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbPctProduitsRetenus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbNbProduitsRetenus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNbProduitsPresentes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNbTotalVisites = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAfficherNbVisitesSpecialite);
            this.groupBox1.Controls.Add(this.tbNbVisitesSpecialite);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSpecialite);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(695, 316);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(560, 250);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre de visites par spécialité";
            // 
            // btnAfficherNbVisitesSpecialite
            // 
            this.btnAfficherNbVisitesSpecialite.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAfficherNbVisitesSpecialite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherNbVisitesSpecialite.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficherNbVisitesSpecialite.Image")));
            this.btnAfficherNbVisitesSpecialite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAfficherNbVisitesSpecialite.Location = new System.Drawing.Point(175, 107);
            this.btnAfficherNbVisitesSpecialite.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficherNbVisitesSpecialite.Name = "btnAfficherNbVisitesSpecialite";
            this.btnAfficherNbVisitesSpecialite.Size = new System.Drawing.Size(203, 55);
            this.btnAfficherNbVisitesSpecialite.TabIndex = 17;
            this.btnAfficherNbVisitesSpecialite.Text = "&Afficher";
            this.btnAfficherNbVisitesSpecialite.UseVisualStyleBackColor = false;
            this.btnAfficherNbVisitesSpecialite.Click += new System.EventHandler(this.btnAfficherNbVisitesSpecialite_Click);
            // 
            // tbNbVisitesSpecialite
            // 
            this.tbNbVisitesSpecialite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNbVisitesSpecialite.Location = new System.Drawing.Point(244, 193);
            this.tbNbVisitesSpecialite.Margin = new System.Windows.Forms.Padding(4);
            this.tbNbVisitesSpecialite.Name = "tbNbVisitesSpecialite";
            this.tbNbVisitesSpecialite.Size = new System.Drawing.Size(81, 26);
            this.tbNbVisitesSpecialite.TabIndex = 15;
            this.tbNbVisitesSpecialite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nombre de visites : ";
            // 
            // tbSpecialite
            // 
            this.tbSpecialite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSpecialite.Location = new System.Drawing.Point(175, 50);
            this.tbSpecialite.Margin = new System.Windows.Forms.Padding(4);
            this.tbSpecialite.Name = "tbSpecialite";
            this.tbSpecialite.Size = new System.Drawing.Size(317, 26);
            this.tbSpecialite.TabIndex = 13;
            this.tbSpecialite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Spécialité : ";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.Location = new System.Drawing.Point(573, 623);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(203, 55);
            this.btnFermer.TabIndex = 16;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbVisiteur);
            this.groupBox2.Controls.Add(this.btnAfficherNbVisitesVisiteur);
            this.groupBox2.Controls.Add(this.tbNbVisitesVisiteur);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(695, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(560, 250);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nombre de visites par visiteur";
            // 
            // cbVisiteur
            // 
            this.cbVisiteur.FormattingEnabled = true;
            this.cbVisiteur.Location = new System.Drawing.Point(153, 54);
            this.cbVisiteur.Margin = new System.Windows.Forms.Padding(4);
            this.cbVisiteur.Name = "cbVisiteur";
            this.cbVisiteur.Size = new System.Drawing.Size(375, 28);
            this.cbVisiteur.TabIndex = 18;
            // 
            // btnAfficherNbVisitesVisiteur
            // 
            this.btnAfficherNbVisitesVisiteur.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAfficherNbVisitesVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherNbVisitesVisiteur.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficherNbVisitesVisiteur.Image")));
            this.btnAfficherNbVisitesVisiteur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAfficherNbVisitesVisiteur.Location = new System.Drawing.Point(175, 107);
            this.btnAfficherNbVisitesVisiteur.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficherNbVisitesVisiteur.Name = "btnAfficherNbVisitesVisiteur";
            this.btnAfficherNbVisitesVisiteur.Size = new System.Drawing.Size(203, 55);
            this.btnAfficherNbVisitesVisiteur.TabIndex = 17;
            this.btnAfficherNbVisitesVisiteur.Text = "&Afficher";
            this.btnAfficherNbVisitesVisiteur.UseVisualStyleBackColor = false;
            this.btnAfficherNbVisitesVisiteur.Click += new System.EventHandler(this.btnAfficherNbVisitesVisiteur_Click);
            // 
            // tbNbVisitesVisiteur
            // 
            this.tbNbVisitesVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNbVisitesVisiteur.Location = new System.Drawing.Point(244, 193);
            this.tbNbVisitesVisiteur.Margin = new System.Windows.Forms.Padding(4);
            this.tbNbVisitesVisiteur.Name = "tbNbVisitesVisiteur";
            this.tbNbVisitesVisiteur.Size = new System.Drawing.Size(81, 26);
            this.tbNbVisitesVisiteur.TabIndex = 15;
            this.tbNbVisitesVisiteur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre de visites : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Visiteur : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbProfessionnel);
            this.groupBox3.Controls.Add(this.btnAfficherNbVisitesProfessionnel);
            this.groupBox3.Controls.Add(this.tbNbVisitesProfessionnel);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(79, 316);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(560, 250);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nombre de visites par professionnel";
            // 
            // cbProfessionnel
            // 
            this.cbProfessionnel.FormattingEnabled = true;
            this.cbProfessionnel.Location = new System.Drawing.Point(153, 54);
            this.cbProfessionnel.Margin = new System.Windows.Forms.Padding(4);
            this.cbProfessionnel.Name = "cbProfessionnel";
            this.cbProfessionnel.Size = new System.Drawing.Size(375, 28);
            this.cbProfessionnel.TabIndex = 18;
            // 
            // btnAfficherNbVisitesProfessionnel
            // 
            this.btnAfficherNbVisitesProfessionnel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAfficherNbVisitesProfessionnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherNbVisitesProfessionnel.Image = ((System.Drawing.Image)(resources.GetObject("btnAfficherNbVisitesProfessionnel.Image")));
            this.btnAfficherNbVisitesProfessionnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAfficherNbVisitesProfessionnel.Location = new System.Drawing.Point(175, 107);
            this.btnAfficherNbVisitesProfessionnel.Margin = new System.Windows.Forms.Padding(4);
            this.btnAfficherNbVisitesProfessionnel.Name = "btnAfficherNbVisitesProfessionnel";
            this.btnAfficherNbVisitesProfessionnel.Size = new System.Drawing.Size(203, 55);
            this.btnAfficherNbVisitesProfessionnel.TabIndex = 17;
            this.btnAfficherNbVisitesProfessionnel.Text = "&Afficher";
            this.btnAfficherNbVisitesProfessionnel.UseVisualStyleBackColor = false;
            this.btnAfficherNbVisitesProfessionnel.Click += new System.EventHandler(this.btnAfficherNbVisitesProfessionnel_Click);
            // 
            // tbNbVisitesProfessionnel
            // 
            this.tbNbVisitesProfessionnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNbVisitesProfessionnel.Location = new System.Drawing.Point(244, 193);
            this.tbNbVisitesProfessionnel.Margin = new System.Windows.Forms.Padding(4);
            this.tbNbVisitesProfessionnel.Name = "tbNbVisitesProfessionnel";
            this.tbNbVisitesProfessionnel.Size = new System.Drawing.Size(81, 26);
            this.tbNbVisitesProfessionnel.TabIndex = 15;
            this.tbNbVisitesProfessionnel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nombre de visites : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Professionnel :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbPctProduitsRetenus);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbNbProduitsRetenus);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.tbNbProduitsPresentes);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.tbNbTotalVisites);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(72, 44);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(596, 245);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informations générales";
            // 
            // tbPctProduitsRetenus
            // 
            this.tbPctProduitsRetenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPctProduitsRetenus.Location = new System.Drawing.Point(373, 171);
            this.tbPctProduitsRetenus.Margin = new System.Windows.Forms.Padding(4);
            this.tbPctProduitsRetenus.Name = "tbPctProduitsRetenus";
            this.tbPctProduitsRetenus.Size = new System.Drawing.Size(81, 26);
            this.tbPctProduitsRetenus.TabIndex = 19;
            this.tbPctProduitsRetenus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 175);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Pourcentage de produits retenus : ";
            // 
            // tbNbProduitsRetenus
            // 
            this.tbNbProduitsRetenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNbProduitsRetenus.Location = new System.Drawing.Point(373, 132);
            this.tbNbProduitsRetenus.Margin = new System.Windows.Forms.Padding(4);
            this.tbNbProduitsRetenus.Name = "tbNbProduitsRetenus";
            this.tbNbProduitsRetenus.Size = new System.Drawing.Size(81, 26);
            this.tbNbProduitsRetenus.TabIndex = 17;
            this.tbNbProduitsRetenus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 135);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nombre total de produits retenus : ";
            // 
            // tbNbProduitsPresentes
            // 
            this.tbNbProduitsPresentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNbProduitsPresentes.Location = new System.Drawing.Point(373, 92);
            this.tbNbProduitsPresentes.Margin = new System.Windows.Forms.Padding(4);
            this.tbNbProduitsPresentes.Name = "tbNbProduitsPresentes";
            this.tbNbProduitsPresentes.Size = new System.Drawing.Size(81, 26);
            this.tbNbProduitsPresentes.TabIndex = 15;
            this.tbNbProduitsPresentes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 96);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nombre total de produits présentés : ";
            // 
            // tbNbTotalVisites
            // 
            this.tbNbTotalVisites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNbTotalVisites.Location = new System.Drawing.Point(373, 53);
            this.tbNbTotalVisites.Margin = new System.Windows.Forms.Padding(4);
            this.tbNbTotalVisites.Name = "tbNbTotalVisites";
            this.tbNbTotalVisites.Size = new System.Drawing.Size(81, 26);
            this.tbNbTotalVisites.TabIndex = 13;
            this.tbNbTotalVisites.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre total de visites : ";
            // 
            // FrmVisiteStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 804);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVisiteStatistiques";
            this.Text = "Statistiques sur les visites";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVisiteStatistiques_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNbVisitesSpecialite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSpecialite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAfficherNbVisitesSpecialite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbVisiteur;
        private System.Windows.Forms.Button btnAfficherNbVisitesVisiteur;
        private System.Windows.Forms.TextBox tbNbVisitesVisiteur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbProfessionnel;
        private System.Windows.Forms.Button btnAfficherNbVisitesProfessionnel;
        private System.Windows.Forms.TextBox tbNbVisitesProfessionnel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbPctProduitsRetenus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbNbProduitsRetenus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNbProduitsPresentes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNbTotalVisites;
        private System.Windows.Forms.Label label1;
    }
}