namespace DP3_Communaute
{
    partial class frmInfluenceurCommunaute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfluenceurCommunaute));
            this.label1 = new System.Windows.Forms.Label();
            this.cbCommunaute = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLoquace = new System.Windows.Forms.TextBox();
            this.tbInactif = new System.Windows.Forms.TextBox();
            this.tbInjure = new System.Windows.Forms.TextBox();
            this.btQuitter = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbLoquace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoquace)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Communaute :";
            // 
            // cbCommunaute
            // 
            this.cbCommunaute.FormattingEnabled = true;
            this.cbCommunaute.Location = new System.Drawing.Point(136, 9);
            this.cbCommunaute.Name = "cbCommunaute";
            this.cbCommunaute.Size = new System.Drawing.Size(219, 28);
            this.cbCommunaute.TabIndex = 4;
            this.cbCommunaute.SelectedIndexChanged += new System.EventHandler(this.cbCommunaute_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Membre \r\nle plus loquace";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Membre \r\nle plus inactif";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "Membre \r\naux désirs injurieux";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLoquace
            // 
            this.tbLoquace.Location = new System.Drawing.Point(12, 239);
            this.tbLoquace.Name = "tbLoquace";
            this.tbLoquace.ReadOnly = true;
            this.tbLoquace.Size = new System.Drawing.Size(161, 27);
            this.tbLoquace.TabIndex = 8;
            // 
            // tbInactif
            // 
            this.tbInactif.Location = new System.Drawing.Point(211, 239);
            this.tbInactif.Name = "tbInactif";
            this.tbInactif.ReadOnly = true;
            this.tbInactif.Size = new System.Drawing.Size(161, 27);
            this.tbInactif.TabIndex = 9;
            // 
            // tbInjure
            // 
            this.tbInjure.Location = new System.Drawing.Point(407, 239);
            this.tbInjure.Name = "tbInjure";
            this.tbInjure.ReadOnly = true;
            this.tbInjure.Size = new System.Drawing.Size(161, 27);
            this.tbInjure.TabIndex = 10;
            // 
            // btQuitter
            // 
            this.btQuitter.Location = new System.Drawing.Point(440, 272);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(128, 49);
            this.btQuitter.TabIndex = 11;
            this.btQuitter.Text = "QUITTER";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DP3_Communaute.Properties.Resources.injure2;
            this.pictureBox2.Location = new System.Drawing.Point(422, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DP3_Communaute.Properties.Resources.inactif;
            this.pictureBox1.Location = new System.Drawing.Point(227, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pbLoquace
            // 
            this.pbLoquace.Image = global::DP3_Communaute.Properties.Resources.loquace;
            this.pbLoquace.Location = new System.Drawing.Point(30, 55);
            this.pbLoquace.Name = "pbLoquace";
            this.pbLoquace.Size = new System.Drawing.Size(128, 128);
            this.pbLoquace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoquace.TabIndex = 0;
            this.pbLoquace.TabStop = false;
            // 
            // frmInfluenceurCommunaute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(578, 326);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.tbInjure);
            this.Controls.Add(this.tbInactif);
            this.Controls.Add(this.tbLoquace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCommunaute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbLoquace);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInfluenceurCommunaute";
            this.Text = "Influenceurs de la communauté";
            this.Load += new System.EventHandler(this.frmInfluenceurCommunaute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoquace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLoquace;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCommunaute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLoquace;
        private System.Windows.Forms.TextBox tbInactif;
        private System.Windows.Forms.TextBox tbInjure;
        private System.Windows.Forms.Button btQuitter;
    }
}