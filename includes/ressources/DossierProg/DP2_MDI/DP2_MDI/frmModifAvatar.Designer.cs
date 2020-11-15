namespace DP2_MDI
{
    partial class frmModifAvatar
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
            this.btQuitter = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMail = new System.Windows.Forms.Label();
            this.pbActAvatar = new System.Windows.Forms.PictureBox();
            this.pbNvAvatar = new System.Windows.Forms.PictureBox();
            this.btAvatar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbActAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNvAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(157, 173);
            this.btQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(88, 32);
            this.btQuitter.TabIndex = 43;
            this.btQuitter.Text = "QUITTER";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btValider
            // 
            this.btValider.Enabled = false;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(33, 173);
            this.btValider.Margin = new System.Windows.Forms.Padding(2);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(88, 32);
            this.btValider.TabIndex = 42;
            this.btValider.Text = "VALIDER";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nouveau avatar :";
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMail.Location = new System.Drawing.Point(9, 37);
            this.lbMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(99, 17);
            this.lbMail.TabIndex = 38;
            this.lbMail.Text = "Avatar actuel :";
            // 
            // pbActAvatar
            // 
            this.pbActAvatar.Enabled = false;
            this.pbActAvatar.Location = new System.Drawing.Point(223, 11);
            this.pbActAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.pbActAvatar.Name = "pbActAvatar";
            this.pbActAvatar.Size = new System.Drawing.Size(64, 64);
            this.pbActAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbActAvatar.TabIndex = 44;
            this.pbActAvatar.TabStop = false;
            // 
            // pbNvAvatar
            // 
            this.pbNvAvatar.Enabled = false;
            this.pbNvAvatar.Location = new System.Drawing.Point(223, 94);
            this.pbNvAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.pbNvAvatar.Name = "pbNvAvatar";
            this.pbNvAvatar.Size = new System.Drawing.Size(64, 64);
            this.pbNvAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNvAvatar.TabIndex = 45;
            this.pbNvAvatar.TabStop = false;
            // 
            // btAvatar
            // 
            this.btAvatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAvatar.Location = new System.Drawing.Point(135, 107);
            this.btAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.btAvatar.Name = "btAvatar";
            this.btAvatar.Size = new System.Drawing.Size(72, 31);
            this.btAvatar.TabIndex = 46;
            this.btAvatar.Text = "Avatar";
            this.btAvatar.UseVisualStyleBackColor = true;
            this.btAvatar.Click += new System.EventHandler(this.btAvatar_Click);
            // 
            // frmModifAvatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(298, 215);
            this.Controls.Add(this.btAvatar);
            this.Controls.Add(this.pbNvAvatar);
            this.Controls.Add(this.pbActAvatar);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmModifAvatar";
            this.Text = "Modifier avatar";
            this.Load += new System.EventHandler(this.frmModifAvatar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbActAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNvAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.PictureBox pbActAvatar;
        private System.Windows.Forms.PictureBox pbNvAvatar;
        private System.Windows.Forms.Button btAvatar;
    }
}