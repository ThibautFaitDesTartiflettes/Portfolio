namespace DP3_Communaute
{
    partial class frmRejoindreCommunaute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRejoindreCommunaute));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbJoueur = new System.Windows.Forms.ComboBox();
            this.cbCommunaute = new System.Windows.Forms.ComboBox();
            this.btRejoindre = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Communaute :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Joueur :";
            // 
            // cbJoueur
            // 
            this.cbJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJoueur.FormattingEnabled = true;
            this.cbJoueur.Location = new System.Drawing.Point(156, 20);
            this.cbJoueur.Name = "cbJoueur";
            this.cbJoueur.Size = new System.Drawing.Size(205, 28);
            this.cbJoueur.TabIndex = 2;
            this.cbJoueur.SelectedIndexChanged += new System.EventHandler(this.cbJoueur_SelectedIndexChanged);
            // 
            // cbCommunaute
            // 
            this.cbCommunaute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCommunaute.FormattingEnabled = true;
            this.cbCommunaute.Location = new System.Drawing.Point(156, 66);
            this.cbCommunaute.Name = "cbCommunaute";
            this.cbCommunaute.Size = new System.Drawing.Size(205, 28);
            this.cbCommunaute.TabIndex = 3;
            this.cbCommunaute.SelectedIndexChanged += new System.EventHandler(this.cbCommunaute_SelectedIndexChanged);
            // 
            // btRejoindre
            // 
            this.btRejoindre.Enabled = false;
            this.btRejoindre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRejoindre.Location = new System.Drawing.Point(16, 116);
            this.btRejoindre.Name = "btRejoindre";
            this.btRejoindre.Size = new System.Drawing.Size(133, 42);
            this.btRejoindre.TabIndex = 4;
            this.btRejoindre.Text = "REJOINDRE";
            this.btRejoindre.UseVisualStyleBackColor = true;
            this.btRejoindre.Click += new System.EventHandler(this.btRejoindre_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(228, 116);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(133, 42);
            this.btQuitter.TabIndex = 5;
            this.btQuitter.Text = "QUITTER";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // frmRejoindreCommunaute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(374, 170);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btRejoindre);
            this.Controls.Add(this.cbCommunaute);
            this.Controls.Add(this.cbJoueur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRejoindreCommunaute";
            this.Text = "Rejoindre une communaute";
            this.Load += new System.EventHandler(this.frmRejoindreCommunaute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbJoueur;
        private System.Windows.Forms.ComboBox cbCommunaute;
        private System.Windows.Forms.Button btRejoindre;
        private System.Windows.Forms.Button btQuitter;
    }
}