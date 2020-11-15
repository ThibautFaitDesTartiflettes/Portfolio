namespace DP3_Communaute
{
    partial class frmSupCommunaute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupCommunaute));
            this.label4 = new System.Windows.Forms.Label();
            this.cbCommunaute = new System.Windows.Forms.ComboBox();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Communaute :";
            // 
            // cbCommunaute
            // 
            this.cbCommunaute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCommunaute.FormattingEnabled = true;
            this.cbCommunaute.Location = new System.Drawing.Point(175, 19);
            this.cbCommunaute.Name = "cbCommunaute";
            this.cbCommunaute.Size = new System.Drawing.Size(231, 28);
            this.cbCommunaute.TabIndex = 30;
            // 
            // btSupprimer
            // 
            this.btSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimer.Location = new System.Drawing.Point(12, 66);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(130, 43);
            this.btSupprimer.TabIndex = 32;
            this.btSupprimer.Text = "SUPPRIMER";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(276, 66);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(130, 43);
            this.btQuitter.TabIndex = 33;
            this.btQuitter.Text = "QUITTER";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // frmSupCommunaute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(418, 121);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCommunaute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSupCommunaute";
            this.Text = "Supprimer une communauté";
            this.Load += new System.EventHandler(this.frmSupCommunaute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCommunaute;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btQuitter;
    }
}