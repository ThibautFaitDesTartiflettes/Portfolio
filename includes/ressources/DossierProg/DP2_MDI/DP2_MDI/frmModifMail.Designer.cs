namespace DP2_MDI
{
    partial class frmModifMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifMail));
            this.tbActMail = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.tbNvMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btQuitter = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbActMail
            // 
            this.tbActMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActMail.Location = new System.Drawing.Point(107, 11);
            this.tbActMail.Margin = new System.Windows.Forms.Padding(2);
            this.tbActMail.Name = "tbActMail";
            this.tbActMail.ReadOnly = true;
            this.tbActMail.Size = new System.Drawing.Size(272, 23);
            this.tbActMail.TabIndex = 31;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(9, 14);
            this.lbMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(83, 17);
            this.lbMail.TabIndex = 30;
            this.lbMail.Text = "Mail actuel :";
            // 
            // tbNvMail
            // 
            this.tbNvMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNvMail.Location = new System.Drawing.Point(107, 51);
            this.tbNvMail.Margin = new System.Windows.Forms.Padding(2);
            this.tbNvMail.Name = "tbNvMail";
            this.tbNvMail.Size = new System.Drawing.Size(272, 23);
            this.tbNvMail.TabIndex = 33;
            this.tbNvMail.TextChanged += new System.EventHandler(this.tbNvMail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nouveau mail :";
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(228, 86);
            this.btQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(88, 32);
            this.btQuitter.TabIndex = 35;
            this.btQuitter.Text = "QUITTER";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btValider
            // 
            this.btValider.Enabled = false;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(72, 86);
            this.btValider.Margin = new System.Windows.Forms.Padding(2);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(88, 32);
            this.btValider.TabIndex = 34;
            this.btValider.Text = "VALIDER";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // frmModifMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(390, 129);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.tbNvMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbActMail);
            this.Controls.Add(this.lbMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmModifMail";
            this.Text = "Modifier mail";
            this.Load += new System.EventHandler(this.frmModifMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbActMail;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.TextBox tbNvMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btValider;
    }
}