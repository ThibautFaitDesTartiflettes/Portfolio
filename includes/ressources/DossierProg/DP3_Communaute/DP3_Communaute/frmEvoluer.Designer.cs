namespace DP3_Communaute
{
    partial class frmEvoluer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvoluer));
            this.btPasserUnNiveau = new System.Windows.Forms.Button();
            this.tbNvNiveau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbActNiveau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btQuitter = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.cbJoueur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btPasserUnNiveau
            // 
            this.btPasserUnNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPasserUnNiveau.Location = new System.Drawing.Point(13, 163);
            this.btPasserUnNiveau.Margin = new System.Windows.Forms.Padding(4);
            this.btPasserUnNiveau.Name = "btPasserUnNiveau";
            this.btPasserUnNiveau.Size = new System.Drawing.Size(333, 47);
            this.btPasserUnNiveau.TabIndex = 32;
            this.btPasserUnNiveau.Text = "Passer un niveau";
            this.btPasserUnNiveau.UseVisualStyleBackColor = true;
            this.btPasserUnNiveau.Click += new System.EventHandler(this.btPasserUnNiveau_Click);
            // 
            // tbNvNiveau
            // 
            this.tbNvNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNvNiveau.Location = new System.Drawing.Point(172, 113);
            this.tbNvNiveau.Margin = new System.Windows.Forms.Padding(4);
            this.tbNvNiveau.Name = "tbNvNiveau";
            this.tbNvNiveau.Size = new System.Drawing.Size(175, 26);
            this.tbNvNiveau.TabIndex = 31;
            this.tbNvNiveau.TextChanged += new System.EventHandler(this.tbNvNiveau_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nouveau niveau :";
            // 
            // tbActNiveau
            // 
            this.tbActNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActNiveau.Location = new System.Drawing.Point(172, 59);
            this.tbActNiveau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbActNiveau.Name = "tbActNiveau";
            this.tbActNiveau.ReadOnly = true;
            this.tbActNiveau.Size = new System.Drawing.Size(175, 27);
            this.tbActNiveau.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Niveau actuel :";
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(229, 227);
            this.btQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(117, 39);
            this.btQuitter.TabIndex = 27;
            this.btQuitter.Text = "QUITTER";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btValider
            // 
            this.btValider.Enabled = false;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(13, 227);
            this.btValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(117, 39);
            this.btValider.TabIndex = 26;
            this.btValider.Text = "VALIDER";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // cbJoueur
            // 
            this.cbJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJoueur.FormattingEnabled = true;
            this.cbJoueur.Location = new System.Drawing.Point(107, 16);
            this.cbJoueur.Name = "cbJoueur";
            this.cbJoueur.Size = new System.Drawing.Size(240, 28);
            this.cbJoueur.TabIndex = 48;
            this.cbJoueur.SelectedIndexChanged += new System.EventHandler(this.cbJoueur_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Joueur :";
            // 
            // frmEvoluer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(359, 273);
            this.Controls.Add(this.cbJoueur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btPasserUnNiveau);
            this.Controls.Add(this.tbNvNiveau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbActNiveau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btValider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEvoluer";
            this.Text = "Evoluer";
            this.Load += new System.EventHandler(this.frmEvoluer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPasserUnNiveau;
        private System.Windows.Forms.TextBox tbNvNiveau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbActNiveau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.ComboBox cbJoueur;
        private System.Windows.Forms.Label label3;
    }
}