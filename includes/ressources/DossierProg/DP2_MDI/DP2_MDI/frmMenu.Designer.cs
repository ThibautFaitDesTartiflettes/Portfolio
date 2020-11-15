namespace DP2_MDI
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
            this.nouveauJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirJoueurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierAvatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evoluerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauJoueurToolStripMenuItem,
            this.voirJoueurToolStripMenuItem,
            this.modifierMailToolStripMenuItem,
            this.modifierAvatarToolStripMenuItem,
            this.evoluerToolStripMenuItem,
            this.pointToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(1112, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "MenuStrip";
            // 
            // nouveauJoueurToolStripMenuItem
            // 
            this.nouveauJoueurToolStripMenuItem.Name = "nouveauJoueurToolStripMenuItem";
            this.nouveauJoueurToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.nouveauJoueurToolStripMenuItem.Text = "Nouveau Joueur";
            this.nouveauJoueurToolStripMenuItem.Click += new System.EventHandler(this.nouveauJoueurToolStripMenuItem_Click);
            // 
            // voirJoueurToolStripMenuItem
            // 
            this.voirJoueurToolStripMenuItem.Name = "voirJoueurToolStripMenuItem";
            this.voirJoueurToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.voirJoueurToolStripMenuItem.Text = "Voir Joueur";
            this.voirJoueurToolStripMenuItem.Click += new System.EventHandler(this.voirJoueurToolStripMenuItem_Click);
            // 
            // modifierMailToolStripMenuItem
            // 
            this.modifierMailToolStripMenuItem.Name = "modifierMailToolStripMenuItem";
            this.modifierMailToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.modifierMailToolStripMenuItem.Text = "Modifier mail";
            this.modifierMailToolStripMenuItem.Click += new System.EventHandler(this.modifierMailToolStripMenuItem_Click);
            // 
            // modifierAvatarToolStripMenuItem
            // 
            this.modifierAvatarToolStripMenuItem.Name = "modifierAvatarToolStripMenuItem";
            this.modifierAvatarToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.modifierAvatarToolStripMenuItem.Text = "Modifier avatar";
            this.modifierAvatarToolStripMenuItem.Click += new System.EventHandler(this.modifierAvatarToolStripMenuItem_Click);
            // 
            // evoluerToolStripMenuItem
            // 
            this.evoluerToolStripMenuItem.Name = "evoluerToolStripMenuItem";
            this.evoluerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.evoluerToolStripMenuItem.Text = "Evoluer";
            this.evoluerToolStripMenuItem.Click += new System.EventHandler(this.evoluerToolStripMenuItem_Click);
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.pointToolStripMenuItem.Text = "Points";
            this.pointToolStripMenuItem.Click += new System.EventHandler(this.pointToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1112, 716);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PacMan vs Fantômes";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem nouveauJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirJoueurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierMailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierAvatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evoluerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
    }
}

