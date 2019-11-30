namespace SelectStatements
{
    partial class frmTekCift
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbTek = new System.Windows.Forms.ComboBox();
            this.lstCift = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(117, 62);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(117, 108);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbTek
            // 
            this.cmbTek.FormattingEnabled = true;
            this.cmbTek.Location = new System.Drawing.Point(302, 62);
            this.cmbTek.Name = "cmbTek";
            this.cmbTek.Size = new System.Drawing.Size(121, 21);
            this.cmbTek.TabIndex = 2;
            // 
            // lstCift
            // 
            this.lstCift.FormattingEnabled = true;
            this.lstCift.Location = new System.Drawing.Point(516, 62);
            this.lstCift.Name = "lstCift";
            this.lstCift.Size = new System.Drawing.Size(120, 95);
            this.lstCift.TabIndex = 3;
            // 
            // frmTekCift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCift);
            this.Controls.Add(this.cmbTek);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSayi);
            this.Name = "frmTekCift";
            this.Text = "frmTekCift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbTek;
        private System.Windows.Forms.ListBox lstCift;
    }
}