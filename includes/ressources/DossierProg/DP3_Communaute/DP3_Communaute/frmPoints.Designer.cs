namespace DP3_Communaute
{
    partial class frmPoints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPoints));
            this.tbNvPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbActPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btQuitter = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.cbJoueur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNvPoint
            // 
            this.tbNvPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNvPoint.Location = new System.Drawing.Point(257, 103);
            this.tbNvPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNvPoint.Name = "tbNvPoint";
            this.tbNvPoint.Size = new System.Drawing.Size(89, 27);
            this.tbNvPoint.TabIndex = 24;
            this.tbNvPoint.TextChanged += new System.EventHandler(this.tbNvPoint_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nouveau nombre de point :";
            // 
            // tbActPoint
            // 
            this.tbActPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActPoint.Location = new System.Drawing.Point(257, 52);
            this.tbActPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbActPoint.Name = "tbActPoint";
            this.tbActPoint.ReadOnly = true;
            this.tbActPoint.Size = new System.Drawing.Size(89, 27);
            this.tbActPoint.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre de points actuel :";
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(231, 150);
            this.btQuitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(117, 39);
            this.btQuitter.TabIndex = 20;
            this.btQuitter.Text = "QUITTER";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btValider
            // 
            this.btValider.Enabled = false;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(13, 151);
            this.btValider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(117, 39);
            this.btValider.TabIndex = 19;
            this.btValider.Text = "VALIDER";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // cbJoueur
            // 
            this.cbJoueur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJoueur.FormattingEnabled = true;
            this.cbJoueur.Location = new System.Drawing.Point(104, 12);
            this.cbJoueur.Name = "cbJoueur";
            this.cbJoueur.Size = new System.Drawing.Size(242, 28);
            this.cbJoueur.TabIndex = 48;
            this.cbJoueur.SelectedIndexChanged += new System.EventHandler(this.cbJoueur_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Joueur :";
            // 
            // frmPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(355, 197);
            this.Controls.Add(this.cbJoueur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNvPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbActPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btValider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPoints";
            this.Text = "Points";
            this.Load += new System.EventHandler(this.frmPoints_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNvPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbActPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.ComboBox cbJoueur;
        private System.Windows.Forms.Label label3;
    }
}