namespace DP1_Personnage
{
    partial class DP1_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DP1_form));
            this.ilPacMan = new System.Windows.Forms.ImageList(this.components);
            this.pbPokey = new System.Windows.Forms.PictureBox();
            this.pbPinky = new System.Windows.Forms.PictureBox();
            this.pbInky = new System.Windows.Forms.PictureBox();
            this.pbBlinky = new System.Windows.Forms.PictureBox();
            this.pb_gentil = new System.Windows.Forms.PictureBox();
            this.lbTextTimer = new System.Windows.Forms.Label();
            this.lbTextPoint = new System.Windows.Forms.Label();
            this.lbPoint = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.TimerJeu = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPokey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPinky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlinky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gentil)).BeginInit();
            this.SuspendLayout();
            // 
            // ilPacMan
            // 
            this.ilPacMan.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilPacMan.ImageStream")));
            this.ilPacMan.TransparentColor = System.Drawing.Color.Transparent;
            this.ilPacMan.Images.SetKeyName(0, "pacman_haut.gif");
            this.ilPacMan.Images.SetKeyName(1, "pacman_droite.gif");
            this.ilPacMan.Images.SetKeyName(2, "pacman_bas.gif");
            this.ilPacMan.Images.SetKeyName(3, "pacman_gauche.gif");
            // 
            // pbPokey
            // 
            this.pbPokey.Image = global::DP1_Personnage.Properties.Resources.Pokey;
            this.pbPokey.Location = new System.Drawing.Point(251, 22);
            this.pbPokey.Margin = new System.Windows.Forms.Padding(2);
            this.pbPokey.Name = "pbPokey";
            this.pbPokey.Size = new System.Drawing.Size(48, 69);
            this.pbPokey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPokey.TabIndex = 4;
            this.pbPokey.TabStop = false;
            // 
            // pbPinky
            // 
            this.pbPinky.Image = global::DP1_Personnage.Properties.Resources.Pinky;
            this.pbPinky.Location = new System.Drawing.Point(171, 22);
            this.pbPinky.Margin = new System.Windows.Forms.Padding(2);
            this.pbPinky.Name = "pbPinky";
            this.pbPinky.Size = new System.Drawing.Size(48, 69);
            this.pbPinky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPinky.TabIndex = 3;
            this.pbPinky.TabStop = false;
            // 
            // pbInky
            // 
            this.pbInky.Image = global::DP1_Personnage.Properties.Resources.Inky;
            this.pbInky.Location = new System.Drawing.Point(91, 22);
            this.pbInky.Margin = new System.Windows.Forms.Padding(2);
            this.pbInky.Name = "pbInky";
            this.pbInky.Size = new System.Drawing.Size(48, 69);
            this.pbInky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInky.TabIndex = 2;
            this.pbInky.TabStop = false;
            // 
            // pbBlinky
            // 
            this.pbBlinky.Image = global::DP1_Personnage.Properties.Resources.Blinky;
            this.pbBlinky.Location = new System.Drawing.Point(17, 22);
            this.pbBlinky.Margin = new System.Windows.Forms.Padding(2);
            this.pbBlinky.Name = "pbBlinky";
            this.pbBlinky.Size = new System.Drawing.Size(48, 69);
            this.pbBlinky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBlinky.TabIndex = 1;
            this.pbBlinky.TabStop = false;
            // 
            // pb_gentil
            // 
            this.pb_gentil.Location = new System.Drawing.Point(319, 345);
            this.pb_gentil.Margin = new System.Windows.Forms.Padding(2);
            this.pb_gentil.Name = "pb_gentil";
            this.pb_gentil.Size = new System.Drawing.Size(64, 64);
            this.pb_gentil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_gentil.TabIndex = 0;
            this.pb_gentil.TabStop = false;
            // 
            // lbTextTimer
            // 
            this.lbTextTimer.AutoSize = true;
            this.lbTextTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextTimer.ForeColor = System.Drawing.Color.White;
            this.lbTextTimer.Location = new System.Drawing.Point(649, 9);
            this.lbTextTimer.Name = "lbTextTimer";
            this.lbTextTimer.Size = new System.Drawing.Size(49, 16);
            this.lbTextTimer.TabIndex = 5;
            this.lbTextTimer.Text = "Timer :";
            // 
            // lbTextPoint
            // 
            this.lbTextPoint.AutoSize = true;
            this.lbTextPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextPoint.ForeColor = System.Drawing.Color.White;
            this.lbTextPoint.Location = new System.Drawing.Point(649, 36);
            this.lbTextPoint.Name = "lbTextPoint";
            this.lbTextPoint.Size = new System.Drawing.Size(51, 16);
            this.lbTextPoint.TabIndex = 6;
            this.lbTextPoint.Text = "Points :";
            // 
            // lbPoint
            // 
            this.lbPoint.AutoSize = true;
            this.lbPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoint.ForeColor = System.Drawing.Color.White;
            this.lbPoint.Location = new System.Drawing.Point(700, 36);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(0, 16);
            this.lbPoint.TabIndex = 7;
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.White;
            this.lbTimer.Location = new System.Drawing.Point(700, 9);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(0, 16);
            this.lbTimer.TabIndex = 8;
            // 
            // TimerJeu
            // 
            this.TimerJeu.Interval = 1000;
            this.TimerJeu.Tick += new System.EventHandler(this.TimerJeu_Tick);
            // 
            // DP1_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(736, 716);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.lbTextPoint);
            this.Controls.Add(this.lbTextTimer);
            this.Controls.Add(this.pbPokey);
            this.Controls.Add(this.pbPinky);
            this.Controls.Add(this.pbInky);
            this.Controls.Add(this.pbBlinky);
            this.Controls.Add(this.pb_gentil);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DP1_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dossier Programmation Pac Man";
            this.Load += new System.EventHandler(this.DP1_form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DP1_form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbPokey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPinky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBlinky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_gentil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_gentil;
        private System.Windows.Forms.ImageList ilPacMan;
        private System.Windows.Forms.PictureBox pbBlinky;
        private System.Windows.Forms.PictureBox pbInky;
        private System.Windows.Forms.PictureBox pbPinky;
        private System.Windows.Forms.PictureBox pbPokey;
        private System.Windows.Forms.Label lbTextTimer;
        private System.Windows.Forms.Label lbTextPoint;
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer TimerJeu;
    }
}

