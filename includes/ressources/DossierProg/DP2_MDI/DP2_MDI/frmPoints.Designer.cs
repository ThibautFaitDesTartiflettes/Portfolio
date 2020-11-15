namespace DP2_MDI
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
            this.btQuitter = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbActPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNvPoint = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(173, 91);
            this.btQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(88, 32);
            this.btQuitter.TabIndex = 14;
            this.btQuitter.Text = "QUITTER";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // btValider
            // 
            this.btValider.Enabled = false;
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(10, 92);
            this.btValider.Margin = new System.Windows.Forms.Padding(2);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(88, 32);
            this.btValider.TabIndex = 13;
            this.btValider.Text = "VALIDER";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre de points actuel :";
            // 
            // tbActPoint
            // 
            this.tbActPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbActPoint.Location = new System.Drawing.Point(193, 11);
            this.tbActPoint.Margin = new System.Windows.Forms.Padding(2);
            this.tbActPoint.Name = "tbActPoint";
            this.tbActPoint.ReadOnly = true;
            this.tbActPoint.Size = new System.Drawing.Size(68, 23);
            this.tbActPoint.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nouveau nombre de point :";
            // 
            // tbNvPoint
            // 
            this.tbNvPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNvPoint.Location = new System.Drawing.Point(193, 53);
            this.tbNvPoint.Margin = new System.Windows.Forms.Padding(2);
            this.tbNvPoint.Name = "tbNvPoint";
            this.tbNvPoint.Size = new System.Drawing.Size(68, 23);
            this.tbNvPoint.TabIndex = 18;
            this.tbNvPoint.TextChanged += new System.EventHandler(this.tbNvPoint_TextChanged);
            // 
            // frmPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(272, 134);
            this.Controls.Add(this.tbNvPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbActPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btValider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPoints";
            this.Text = "Points";
            this.Load += new System.EventHandler(this.frmPoints_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbActPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNvPoint;
    }
}