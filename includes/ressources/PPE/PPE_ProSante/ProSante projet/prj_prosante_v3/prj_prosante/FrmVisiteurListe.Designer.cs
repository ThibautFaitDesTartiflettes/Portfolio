namespace prj_prosante
{
    partial class FrmVisiteurListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisiteurListe));
            this.lvVisiteur = new System.Windows.Forms.ListView();
            this.colMatriculeVisiteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNomVisiteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrenomVisiteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumTelephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumSecteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFermer = new System.Windows.Forms.Button();
            this.cbSecteur = new System.Windows.Forms.ComboBox();
            this.btRechercher = new System.Windows.Forms.Button();
            this.btNrecherche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvVisiteur
            // 
            this.lvVisiteur.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMatriculeVisiteur,
            this.colNomVisiteur,
            this.colPrenomVisiteur,
            this.colNumTelephone,
            this.colNumSecteur});
            this.lvVisiteur.HideSelection = false;
            this.lvVisiteur.Location = new System.Drawing.Point(84, 150);
            this.lvVisiteur.Name = "lvVisiteur";
            this.lvVisiteur.Size = new System.Drawing.Size(840, 342);
            this.lvVisiteur.TabIndex = 0;
            this.lvVisiteur.UseCompatibleStateImageBehavior = false;
            this.lvVisiteur.View = System.Windows.Forms.View.Details;
            this.lvVisiteur.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colMatriculeVisiteur
            // 
            this.colMatriculeVisiteur.Text = "Matricule";
            this.colMatriculeVisiteur.Width = 100;
            // 
            // colNomVisiteur
            // 
            this.colNomVisiteur.Text = "Nom";
            this.colNomVisiteur.Width = 200;
            // 
            // colPrenomVisiteur
            // 
            this.colPrenomVisiteur.Text = "Prenom";
            this.colPrenomVisiteur.Width = 200;
            // 
            // colNumTelephone
            // 
            this.colNumTelephone.Text = "Numero";
            this.colNumTelephone.Width = 115;
            // 
            // colNumSecteur
            // 
            this.colNumSecteur.Text = "Secteur";
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Image = ((System.Drawing.Image)(resources.GetObject("btnFermer.Image")));
            this.btnFermer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFermer.Location = new System.Drawing.Point(439, 507);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(152, 45);
            this.btnFermer.TabIndex = 16;
            this.btnFermer.Text = "&Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // cbSecteur
            // 
            this.cbSecteur.FormattingEnabled = true;
            this.cbSecteur.Items.AddRange(new object[] {
            "NORD",
            "OUEST",
            "SUD",
            "PARIS",
            "CENTRE",
            "EST",
            "DTOM"});
            this.cbSecteur.Location = new System.Drawing.Point(403, 74);
            this.cbSecteur.Name = "cbSecteur";
            this.cbSecteur.Size = new System.Drawing.Size(121, 21);
            this.cbSecteur.TabIndex = 17;
            // 
            // btRechercher
            // 
            this.btRechercher.Location = new System.Drawing.Point(541, 74);
            this.btRechercher.Name = "btRechercher";
            this.btRechercher.Size = new System.Drawing.Size(109, 23);
            this.btRechercher.TabIndex = 18;
            this.btRechercher.Text = "Rechercher";
            this.btRechercher.UseVisualStyleBackColor = true;
            this.btRechercher.Click += new System.EventHandler(this.btRechercher_Click);
            // 
            // btNrecherche
            // 
            this.btNrecherche.Location = new System.Drawing.Point(541, 104);
            this.btNrecherche.Name = "btNrecherche";
            this.btNrecherche.Size = new System.Drawing.Size(109, 23);
            this.btNrecherche.TabIndex = 19;
            this.btNrecherche.Text = "Annuler Recherche";
            this.btNrecherche.UseVisualStyleBackColor = true;
            this.btNrecherche.Click += new System.EventHandler(this.btNrecherche_Click);
            // 
            // FrmVisiteurListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 633);
            this.Controls.Add(this.btNrecherche);
            this.Controls.Add(this.btRechercher);
            this.Controls.Add(this.cbSecteur);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.lvVisiteur);
            this.Name = "FrmVisiteurListe";
            this.Text = "Liste des visiteurs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmVisiteurListe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvVisiteur;
        private System.Windows.Forms.ColumnHeader colMatriculeVisiteur;
        private System.Windows.Forms.ColumnHeader colNomVisiteur;
        private System.Windows.Forms.ColumnHeader colPrenomVisiteur;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.ColumnHeader colNumTelephone;
        private System.Windows.Forms.ColumnHeader colNumSecteur;
        private System.Windows.Forms.ComboBox cbSecteur;
        private System.Windows.Forms.Button btRechercher;
        private System.Windows.Forms.Button btNrecherche;
    }
}