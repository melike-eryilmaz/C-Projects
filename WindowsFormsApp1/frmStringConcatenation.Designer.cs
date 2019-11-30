namespace WindowsFormsApp1
{
    partial class frmStringConcatenation
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblAdiniz = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(476, 141);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            this.txtAd.Text = "Melike";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(476, 201);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Text = "ERYILMAZ";
            // 
            // lblAdiniz
            // 
            this.lblAdiniz.AutoSize = true;
            this.lblAdiniz.Location = new System.Drawing.Point(362, 147);
            this.lblAdiniz.Name = "lblAdiniz";
            this.lblAdiniz.Size = new System.Drawing.Size(35, 13);
            this.lblAdiniz.TabIndex = 2;
            this.lblAdiniz.Text = "Adınız";
            this.lblAdiniz.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyadınız";
            // 
            // frmButton
            // 
            this.frmButton.Location = new System.Drawing.Point(485, 267);
            this.frmButton.Name = "frmButton";
            this.frmButton.Size = new System.Drawing.Size(75, 23);
            this.frmButton.TabIndex = 4;
            this.frmButton.Text = "Giriş Yap";
            this.frmButton.UseVisualStyleBackColor = true;
            this.frmButton.Click += new System.EventHandler(this.frmButton_Click);
            // 
            // frmStringConcatenation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdiniz);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "frmStringConcatenation";
            this.Text = "frmStringConcatenation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblAdiniz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button frmButton;
    }
}