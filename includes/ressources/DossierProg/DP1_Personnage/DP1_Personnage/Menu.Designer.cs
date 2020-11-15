namespace DP1_Personnage
{
    partial class Menu
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
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.lbTitre = new System.Windows.Forms.Label();
            this.btJouer = new System.Windows.Forms.Button();
            this.lbObjectif = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMenu
            // 
            this.pbMenu.Image = global::DP1_Personnage.Properties.Resources.menu_fantome;
            this.pbMenu.Location = new System.Drawing.Point(12, 12);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(740, 415);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu.TabIndex = 0;
            this.pbMenu.TabStop = false;
            // 
            // lbTitre
            // 
            this.lbTitre.AutoSize = true;
            this.lbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitre.ForeColor = System.Drawing.Color.White;
            this.lbTitre.Location = new System.Drawing.Point(253, 26);
            this.lbTitre.Name = "lbTitre";
            this.lbTitre.Size = new System.Drawing.Size(284, 25);
            this.lbTitre.TabIndex = 1;
            this.lbTitre.Text = "PAC MAN VS FANTÔMES";
            // 
            // btJouer
            // 
            this.btJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btJouer.Location = new System.Drawing.Point(496, 378);
            this.btJouer.Name = "btJouer";
            this.btJouer.Size = new System.Drawing.Size(118, 49);
            this.btJouer.TabIndex = 4;
            this.btJouer.Text = "JOUER";
            this.btJouer.UseVisualStyleBackColor = true;
            this.btJouer.Click += new System.EventHandler(this.btJouer_Click);
            // 
            // lbObjectif
            // 
            this.lbObjectif.AutoSize = true;
            this.lbObjectif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObjectif.ForeColor = System.Drawing.Color.White;
            this.lbObjectif.Location = new System.Drawing.Point(87, 391);
            this.lbObjectif.Name = "lbObjectif";
            this.lbObjectif.Size = new System.Drawing.Size(303, 24);
            this.lbObjectif.TabIndex = 5;
            this.lbObjectif.Text = "Objectif : 25 points en 60 secondes";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(764, 439);
            this.Controls.Add(this.lbObjectif);
            this.Controls.Add(this.btJouer);
            this.Controls.Add(this.lbTitre);
            this.Controls.Add(this.pbMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Label lbTitre;
        private System.Windows.Forms.Button btJouer;
        private System.Windows.Forms.Label lbObjectif;
    }
}