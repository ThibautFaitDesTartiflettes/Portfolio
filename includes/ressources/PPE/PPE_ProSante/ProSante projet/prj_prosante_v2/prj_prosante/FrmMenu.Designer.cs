namespace prj_prosante
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierOuvrirOptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fichierEnregistrerOptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.fichierQuitterOptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteurMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteurNouveauOptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteurListeOptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.professionnelMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.professionnelNouveauOptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.professionelListeOptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.professionnelListeTousOptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.professionnelListeSpecialiteOptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteSaisirOptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteConsulterOptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.visiteStatistiquesOptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierMenu,
            this.visiteurMenu,
            this.professionnelMenu,
            this.visiteMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fichierMenu
            // 
            this.fichierMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierOuvrirOptionMenu,
            this.toolStripSeparator3,
            this.fichierEnregistrerOptionMenu,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.fichierQuitterOptionMenu});
            this.fichierMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fichierMenu.Name = "fichierMenu";
            this.fichierMenu.Size = new System.Drawing.Size(65, 20);
            this.fichierMenu.Text = "&Données";
            // 
            // fichierOuvrirOptionMenu
            // 
            this.fichierOuvrirOptionMenu.Image = ((System.Drawing.Image)(resources.GetObject("fichierOuvrirOptionMenu.Image")));
            this.fichierOuvrirOptionMenu.ImageTransparentColor = System.Drawing.Color.Black;
            this.fichierOuvrirOptionMenu.Name = "fichierOuvrirOptionMenu";
            this.fichierOuvrirOptionMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.fichierOuvrirOptionMenu.Size = new System.Drawing.Size(170, 22);
            this.fichierOuvrirOptionMenu.Text = "&Ouvrir";
            this.fichierOuvrirOptionMenu.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(167, 6);
            // 
            // fichierEnregistrerOptionMenu
            // 
            this.fichierEnregistrerOptionMenu.Image = ((System.Drawing.Image)(resources.GetObject("fichierEnregistrerOptionMenu.Image")));
            this.fichierEnregistrerOptionMenu.ImageTransparentColor = System.Drawing.Color.Black;
            this.fichierEnregistrerOptionMenu.Name = "fichierEnregistrerOptionMenu";
            this.fichierEnregistrerOptionMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.fichierEnregistrerOptionMenu.Size = new System.Drawing.Size(170, 22);
            this.fichierEnregistrerOptionMenu.Text = "&Enregistrer";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(167, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(167, 6);
            // 
            // fichierQuitterOptionMenu
            // 
            this.fichierQuitterOptionMenu.Name = "fichierQuitterOptionMenu";
            this.fichierQuitterOptionMenu.Size = new System.Drawing.Size(170, 22);
            this.fichierQuitterOptionMenu.Text = "&Quitter";
            this.fichierQuitterOptionMenu.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // visiteurMenu
            // 
            this.visiteurMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visiteurNouveauOptionMenu,
            this.visiteurListeOptionMenu,
            this.toolStripSeparator7});
            this.visiteurMenu.Name = "visiteurMenu";
            this.visiteurMenu.Size = new System.Drawing.Size(58, 20);
            this.visiteurMenu.Text = "&Visiteur";
            // 
            // visiteurNouveauOptionMenu
            // 
            this.visiteurNouveauOptionMenu.Image = ((System.Drawing.Image)(resources.GetObject("visiteurNouveauOptionMenu.Image")));
            this.visiteurNouveauOptionMenu.ImageTransparentColor = System.Drawing.Color.Black;
            this.visiteurNouveauOptionMenu.Name = "visiteurNouveauOptionMenu";
            this.visiteurNouveauOptionMenu.Size = new System.Drawing.Size(122, 22);
            this.visiteurNouveauOptionMenu.Text = "&Nouveau";
            this.visiteurNouveauOptionMenu.Click += new System.EventHandler(this.visiteurNouveauOptionMenu_Click);
            // 
            // visiteurListeOptionMenu
            // 
            this.visiteurListeOptionMenu.Image = ((System.Drawing.Image)(resources.GetObject("visiteurListeOptionMenu.Image")));
            this.visiteurListeOptionMenu.ImageTransparentColor = System.Drawing.Color.Black;
            this.visiteurListeOptionMenu.Name = "visiteurListeOptionMenu";
            this.visiteurListeOptionMenu.Size = new System.Drawing.Size(122, 22);
            this.visiteurListeOptionMenu.Text = "&Liste";
            this.visiteurListeOptionMenu.Click += new System.EventHandler(this.visiteurListeOptionMenu_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(119, 6);
            // 
            // professionnelMenu
            // 
            this.professionnelMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.professionnelNouveauOptionMenu,
            this.professionelListeOptionMenu});
            this.professionnelMenu.Name = "professionnelMenu";
            this.professionnelMenu.Size = new System.Drawing.Size(90, 20);
            this.professionnelMenu.Text = "&Professionnel";
            // 
            // professionnelNouveauOptionMenu
            // 
            this.professionnelNouveauOptionMenu.Checked = true;
            this.professionnelNouveauOptionMenu.CheckOnClick = true;
            this.professionnelNouveauOptionMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.professionnelNouveauOptionMenu.Image = ((System.Drawing.Image)(resources.GetObject("professionnelNouveauOptionMenu.Image")));
            this.professionnelNouveauOptionMenu.Name = "professionnelNouveauOptionMenu";
            this.professionnelNouveauOptionMenu.Size = new System.Drawing.Size(122, 22);
            this.professionnelNouveauOptionMenu.Text = "&Nouveau";
            this.professionnelNouveauOptionMenu.Click += new System.EventHandler(this.professionnelNouveauOptionMenu_Click);
            // 
            // professionelListeOptionMenu
            // 
            this.professionelListeOptionMenu.Checked = true;
            this.professionelListeOptionMenu.CheckOnClick = true;
            this.professionelListeOptionMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.professionelListeOptionMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.professionnelListeTousOptionMenu,
            this.professionnelListeSpecialiteOptionMenu});
            this.professionelListeOptionMenu.Image = ((System.Drawing.Image)(resources.GetObject("professionelListeOptionMenu.Image")));
            this.professionelListeOptionMenu.Name = "professionelListeOptionMenu";
            this.professionelListeOptionMenu.Size = new System.Drawing.Size(122, 22);
            this.professionelListeOptionMenu.Text = "&Liste";
            // 
            // professionnelListeTousOptionMenu
            // 
            this.professionnelListeTousOptionMenu.Image = ((System.Drawing.Image)(resources.GetObject("professionnelListeTousOptionMenu.Image")));
            this.professionnelListeTousOptionMenu.Name = "professionnelListeTousOptionMenu";
            this.professionnelListeTousOptionMenu.Size = new System.Drawing.Size(144, 22);
            this.professionnelListeTousOptionMenu.Text = "&Tous";
            this.professionnelListeTousOptionMenu.Click += new System.EventHandler(this.professionnelListeTousOptionMenu_Click);
            // 
            // professionnelListeSpecialiteOptionMenu
            // 
            this.professionnelListeSpecialiteOptionMenu.Image = ((System.Drawing.Image)(resources.GetObject("professionnelListeSpecialiteOptionMenu.Image")));
            this.professionnelListeSpecialiteOptionMenu.Name = "professionnelListeSpecialiteOptionMenu";
            this.professionnelListeSpecialiteOptionMenu.Size = new System.Drawing.Size(144, 22);
            this.professionnelListeSpecialiteOptionMenu.Text = "par &Spécialité";
            this.professionnelListeSpecialiteOptionMenu.Click += new System.EventHandler(this.professionnelListeSpecialiteOptionMenu_Click);
            // 
            // visiteMenu
            // 
            this.visiteMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visiteSaisirOptionMenu,
            this.visiteConsulterOptionMenu,
            this.visiteStatistiquesOptionMenu});
            this.visiteMenu.Name = "visiteMenu";
            this.visiteMenu.Size = new System.Drawing.Size(47, 20);
            this.visiteMenu.Text = "&Visite";
            // 
            // visiteSaisirOptionMenu
            // 
            this.visiteSaisirOptionMenu.Image = ((System.Drawing.Image)(resources.GetObject("visiteSaisirOptionMenu.Image")));
            this.visiteSaisirOptionMenu.Name = "visiteSaisirOptionMenu";
            this.visiteSaisirOptionMenu.Size = new System.Drawing.Size(134, 22);
            this.visiteSaisirOptionMenu.Text = "&Saisir";
            this.visiteSaisirOptionMenu.Click += new System.EventHandler(this.visiteSaisirOptionMenu_Click);
            // 
            // visiteConsulterOptionMenu
            // 
            this.visiteConsulterOptionMenu.Image = ((System.Drawing.Image)(resources.GetObject("visiteConsulterOptionMenu.Image")));
            this.visiteConsulterOptionMenu.Name = "visiteConsulterOptionMenu";
            this.visiteConsulterOptionMenu.Size = new System.Drawing.Size(134, 22);
            this.visiteConsulterOptionMenu.Text = "&Consulter";
            this.visiteConsulterOptionMenu.Click += new System.EventHandler(this.visiteConsulterOptionMenu_Click);
            // 
            // visiteStatistiquesOptionMenu
            // 
            this.visiteStatistiquesOptionMenu.Image = ((System.Drawing.Image)(resources.GetObject("visiteStatistiquesOptionMenu.Image")));
            this.visiteStatistiquesOptionMenu.Name = "visiteStatistiquesOptionMenu";
            this.visiteStatistiquesOptionMenu.Size = new System.Drawing.Size(134, 22);
            this.visiteStatistiquesOptionMenu.Text = "&Statistiques";
            this.visiteStatistiquesOptionMenu.Click += new System.EventHandler(this.visiteStatistiquesOptionMenu_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(43, 20);
            this.helpMenu.Text = "&Aide";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(159, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.aboutToolStripMenuItem.Text = "&À propos de ... ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(984, 35);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(32, 32);
            this.newToolStripButton.Text = "Nouveau";
            this.newToolStripButton.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(32, 32);
            this.openToolStripButton.Text = "Ouvrir";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(32, 32);
            this.saveToolStripButton.Text = "Enregistrer";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(32, 32);
            this.printToolStripButton.Text = "Imprimer";
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(32, 32);
            this.printPreviewToolStripButton.Text = "Aperçu avant impression";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(32, 32);
            this.helpToolStripButton.Text = "Aide";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 637);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabel.Text = "État";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 659);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProSanté";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierMenu;
        private System.Windows.Forms.ToolStripMenuItem fichierOuvrirOptionMenu;
        private System.Windows.Forms.ToolStripMenuItem fichierEnregistrerOptionMenu;
        private System.Windows.Forms.ToolStripMenuItem fichierQuitterOptionMenu;
        private System.Windows.Forms.ToolStripMenuItem visiteurMenu;
        private System.Windows.Forms.ToolStripMenuItem visiteurNouveauOptionMenu;
        private System.Windows.Forms.ToolStripMenuItem visiteurListeOptionMenu;
        private System.Windows.Forms.ToolStripMenuItem professionnelMenu;
        private System.Windows.Forms.ToolStripMenuItem professionnelNouveauOptionMenu;
        private System.Windows.Forms.ToolStripMenuItem professionelListeOptionMenu;
        private System.Windows.Forms.ToolStripMenuItem visiteMenu;
        private System.Windows.Forms.ToolStripMenuItem visiteSaisirOptionMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem professionnelListeTousOptionMenu;
        private System.Windows.Forms.ToolStripMenuItem professionnelListeSpecialiteOptionMenu;
        private System.Windows.Forms.ToolStripMenuItem visiteConsulterOptionMenu;
        private System.Windows.Forms.ToolStripMenuItem visiteStatistiquesOptionMenu;
    }
}



