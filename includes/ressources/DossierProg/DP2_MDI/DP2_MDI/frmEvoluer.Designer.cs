namespace DP2_MDI
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbActNiveau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btQuitter = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.tbNvNiveau = new System.Windows.Forms.TextBox();
            this.btPasserUnNiveau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nouveau niveau :";
            // 
            // tbActNiveau
            // 
            this.tbActNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActNiveau.Location = new System.Drawing.Point(129, 14);
            this.tbActNiveau.Margin = new System.Windows.Forms.Padding(2);
            this.tbActNiveau.Name = "tbActNiveau";
            this.tbActNiveau.ReadOnly = true;
            this.tbActNiveau.Size = new System.Drawing.Size(101, 23);
            this.tbActNiveau.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Niveau actuel :";
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(142, 150);
            this.btQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(88, 32);
            this.btQuitter.TabIndex = 20;
            this.btQuitter.Text = "QUITTER";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btValider
            // 
            this.btValider.Enabled = false;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(10, 150);
            this.btValider.Margin = new System.Windows.Forms.Padding(2);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(88, 32);
            this.btValider.TabIndex = 19;
            this.btValider.Text = "VALIDER";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // tbNvNiveau
            // 
            this.tbNvNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNvNiveau.Location = new System.Drawing.Point(129, 58);
            this.tbNvNiveau.Name = "tbNvNiveau";
            this.tbNvNiveau.Size = new System.Drawing.Size(101, 22);
            this.tbNvNiveau.TabIndex = 24;
            this.tbNvNiveau.TextChanged += new System.EventHandler(this.tbNvNiveau_TextChanged);
            // 
            // btPasserUnNiveau
            // 
            this.btPasserUnNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPasserUnNiveau.Location = new System.Drawing.Point(10, 98);
            this.btPasserUnNiveau.Name = "btPasserUnNiveau";
            this.btPasserUnNiveau.Size = new System.Drawing.Size(220, 38);
            this.btPasserUnNiveau.TabIndex = 25;
            this.btPasserUnNiveau.Text = "Passer un niveau";
            this.btPasserUnNiveau.UseVisualStyleBackColor = true;
            this.btPasserUnNiveau.Click += new System.EventHandler(this.btPasserUnNiveau_Click);
            // 
            // frmEvoluer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(241, 193);
            this.Controls.Add(this.btPasserUnNiveau);
            this.Controls.Add(this.tbNvNiveau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbActNiveau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btValider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEvoluer";
            this.Text = "Evoluer";
            this.Load += new System.EventHandler(this.frmEvoluer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbActNiveau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.TextBox tbNvNiveau;
        private System.Windows.Forms.Button btPasserUnNiveau;
    }
}