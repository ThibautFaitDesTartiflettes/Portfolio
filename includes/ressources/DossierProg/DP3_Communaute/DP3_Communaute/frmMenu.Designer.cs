namespace DP3_Communaute
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.voirJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauJoueurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.voirJoueurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierMailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierAvatarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rejoindreUneCommunauteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterSaCommunauteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.communauteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleCommunauteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleCommunauteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.voirCommunauteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierCommunauteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerCommunauteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maCommunauteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.influenceursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirJoueurToolStripMenuItem,
            this.nouveauJoueurToolStripMenuItem,
            this.communauteToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1482, 28);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // voirJoueurToolStripMenuItem
            // 
            this.voirJoueurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jeuToolStripMenuItem,
            this.pointsToolStripMenuItem1});
            this.voirJoueurToolStripMenuItem.Name = "voirJoueurToolStripMenuItem";
            this.voirJoueurToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.voirJoueurToolStripMenuItem.Text = "Jeu";
            // 
            // jeuToolStripMenuItem
            // 
            this.jeuToolStripMenuItem.Name = "jeuToolStripMenuItem";
            this.jeuToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.jeuToolStripMenuItem.Text = "Evoluer";
            this.jeuToolStripMenuItem.Click += new System.EventHandler(this.jeuToolStripMenuItem_Click);
            // 
            // pointsToolStripMenuItem1
            // 
            this.pointsToolStripMenuItem1.Name = "pointsToolStripMenuItem1";
            this.pointsToolStripMenuItem1.Size = new System.Drawing.Size(133, 26);
            this.pointsToolStripMenuItem1.Text = "Points";
            this.pointsToolStripMenuItem1.Click += new System.EventHandler(this.pointsToolStripMenuItem1_Click);
            // 
            // nouveauJoueurToolStripMenuItem
            // 
            this.nouveauJoueurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauJoueurToolStripMenuItem1,
            this.voirJoueurToolStripMenuItem1,
            this.modifierMailToolStripMenuItem1,
            this.modifierAvatarToolStripMenuItem1,
            this.rejoindreUneCommunauteToolStripMenuItem,
            this.quitterSaCommunauteToolStripMenuItem});
            this.nouveauJoueurToolStripMenuItem.Name = "nouveauJoueurToolStripMenuItem";
            this.nouveauJoueurToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.nouveauJoueurToolStripMenuItem.Text = "Joueur";
            // 
            // nouveauJoueurToolStripMenuItem1
            // 
            this.nouveauJoueurToolStripMenuItem1.Name = "nouveauJoueurToolStripMenuItem1";
            this.nouveauJoueurToolStripMenuItem1.Size = new System.Drawing.Size(267, 26);
            this.nouveauJoueurToolStripMenuItem1.Text = "Nouveau Joueur";
            this.nouveauJoueurToolStripMenuItem1.Click += new System.EventHandler(this.nouveauJoueurToolStripMenuItem1_Click);
            // 
            // voirJoueurToolStripMenuItem1
            // 
            this.voirJoueurToolStripMenuItem1.Name = "voirJoueurToolStripMenuItem1";
            this.voirJoueurToolStripMenuItem1.Size = new System.Drawing.Size(267, 26);
            this.voirJoueurToolStripMenuItem1.Text = "Voir Joueur";
            this.voirJoueurToolStripMenuItem1.Click += new System.EventHandler(this.voirJoueurToolStripMenuItem1_Click);
            // 
            // modifierMailToolStripMenuItem1
            // 
            this.modifierMailToolStripMenuItem1.Name = "modifierMailToolStripMenuItem1";
            this.modifierMailToolStripMenuItem1.Size = new System.Drawing.Size(267, 26);
            this.modifierMailToolStripMenuItem1.Text = "Modifier mail";
            this.modifierMailToolStripMenuItem1.Click += new System.EventHandler(this.modifierMailToolStripMenuItem1_Click);
            // 
            // modifierAvatarToolStripMenuItem1
            // 
            this.modifierAvatarToolStripMenuItem1.Name = "modifierAvatarToolStripMenuItem1";
            this.modifierAvatarToolStripMenuItem1.Size = new System.Drawing.Size(267, 26);
            this.modifierAvatarToolStripMenuItem1.Text = "Modifier avatar";
            this.modifierAvatarToolStripMenuItem1.Click += new System.EventHandler(this.modifierAvatarToolStripMenuItem1_Click);
            // 
            // rejoindreUneCommunauteToolStripMenuItem
            // 
            this.rejoindreUneCommunauteToolStripMenuItem.Name = "rejoindreUneCommunauteToolStripMenuItem";
            this.rejoindreUneCommunauteToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.rejoindreUneCommunauteToolStripMenuItem.Text = "Rejoindre une communaute";
            this.rejoindreUneCommunauteToolStripMenuItem.Click += new System.EventHandler(this.rejoindreUneCommunauteToolStripMenuItem_Click);
            // 
            // quitterSaCommunauteToolStripMenuItem
            // 
            this.quitterSaCommunauteToolStripMenuItem.Name = "quitterSaCommunauteToolStripMenuItem";
            this.quitterSaCommunauteToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.quitterSaCommunauteToolStripMenuItem.Text = "Quitter sa communaute";
            this.quitterSaCommunauteToolStripMenuItem.Click += new System.EventHandler(this.quitterSaCommunauteToolStripMenuItem_Click);
            // 
            // communauteToolStripMenuItem
            // 
            this.communauteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleCommunauteToolStripMenuItem,
            this.maCommunauteToolStripMenuItem});
            this.communauteToolStripMenuItem.Name = "communauteToolStripMenuItem";
            this.communauteToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.communauteToolStripMenuItem.Text = "Communaute";
            // 
            // nouvelleCommunauteToolStripMenuItem
            // 
            this.nouvelleCommunauteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleCommunauteToolStripMenuItem1,
            this.voirCommunauteToolStripMenuItem1,
            this.modifierCommunauteToolStripMenuItem1,
            this.supprimerCommunauteToolStripMenuItem1});
            this.nouvelleCommunauteToolStripMenuItem.Name = "nouvelleCommunauteToolStripMenuItem";
            this.nouvelleCommunauteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.nouvelleCommunauteToolStripMenuItem.Text = "Gestion";
            // 
            // nouvelleCommunauteToolStripMenuItem1
            // 
            this.nouvelleCommunauteToolStripMenuItem1.Name = "nouvelleCommunauteToolStripMenuItem1";
            this.nouvelleCommunauteToolStripMenuItem1.Size = new System.Drawing.Size(244, 26);
            this.nouvelleCommunauteToolStripMenuItem1.Text = "Nouvelle communaute";
            this.nouvelleCommunauteToolStripMenuItem1.Click += new System.EventHandler(this.nouvelleCommunauteToolStripMenuItem1_Click);
            // 
            // voirCommunauteToolStripMenuItem1
            // 
            this.voirCommunauteToolStripMenuItem1.Name = "voirCommunauteToolStripMenuItem1";
            this.voirCommunauteToolStripMenuItem1.Size = new System.Drawing.Size(244, 26);
            this.voirCommunauteToolStripMenuItem1.Text = "Voir communaute";
            this.voirCommunauteToolStripMenuItem1.Click += new System.EventHandler(this.voirCommunauteToolStripMenuItem1_Click);
            // 
            // modifierCommunauteToolStripMenuItem1
            // 
            this.modifierCommunauteToolStripMenuItem1.Name = "modifierCommunauteToolStripMenuItem1";
            this.modifierCommunauteToolStripMenuItem1.Size = new System.Drawing.Size(244, 26);
            this.modifierCommunauteToolStripMenuItem1.Text = "Modifier communaute";
            this.modifierCommunauteToolStripMenuItem1.Click += new System.EventHandler(this.modifierCommunauteToolStripMenuItem1_Click);
            // 
            // supprimerCommunauteToolStripMenuItem1
            // 
            this.supprimerCommunauteToolStripMenuItem1.Name = "supprimerCommunauteToolStripMenuItem1";
            this.supprimerCommunauteToolStripMenuItem1.Size = new System.Drawing.Size(244, 26);
            this.supprimerCommunauteToolStripMenuItem1.Text = "Supprimer communaute";
            this.supprimerCommunauteToolStripMenuItem1.Click += new System.EventHandler(this.supprimerCommunauteToolStripMenuItem1_Click);
            // 
            // maCommunauteToolStripMenuItem
            // 
            this.maCommunauteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classementToolStripMenuItem,
            this.chatToolStripMenuItem,
            this.influenceursToolStripMenuItem});
            this.maCommunauteToolStripMenuItem.Name = "maCommunauteToolStripMenuItem";
            this.maCommunauteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.maCommunauteToolStripMenuItem.Text = "Ma communaute";
            // 
            // classementToolStripMenuItem
            // 
            this.classementToolStripMenuItem.Name = "classementToolStripMenuItem";
            this.classementToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.classementToolStripMenuItem.Text = "Classement";
            this.classementToolStripMenuItem.Click += new System.EventHandler(this.classementToolStripMenuItem_Click);
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.chatToolStripMenuItem.Text = "Chat";
            this.chatToolStripMenuItem.Click += new System.EventHandler(this.chatToolStripMenuItem_Click);
            // 
            // influenceursToolStripMenuItem
            // 
            this.influenceursToolStripMenuItem.Name = "influenceursToolStripMenuItem";
            this.influenceursToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.influenceursToolStripMenuItem.Text = "Influenceurs";
            this.influenceursToolStripMenuItem.Click += new System.EventHandler(this.influenceursToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 953);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PacMan vs Fantômes";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem nouveauJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirJoueurToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierMailToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierAvatarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jeuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nouveauJoueurToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem communauteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleCommunauteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleCommunauteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem voirCommunauteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierCommunauteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem supprimerCommunauteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rejoindreUneCommunauteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterSaCommunauteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maCommunauteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem influenceursToolStripMenuItem;
    }
}

