namespace WindowsFormsApp1
{
    partial class frmSayıvs
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAlinan = new System.Windows.Forms.TextBox();
            this.lstSayi = new System.Windows.Forms.ListBox();
            this.lstVeri = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(239, 232);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "ekle ";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAlinan
            // 
            this.txtAlinan.Location = new System.Drawing.Point(54, 232);
            this.txtAlinan.Name = "txtAlinan";
            this.txtAlinan.Size = new System.Drawing.Size(100, 20);
            this.txtAlinan.TabIndex = 1;
            // 
            // lstSayi
            // 
            this.lstSayi.FormattingEnabled = true;
            this.lstSayi.Location = new System.Drawing.Point(54, 71);
            this.lstSayi.Name = "lstSayi";
            this.lstSayi.Size = new System.Drawing.Size(120, 95);
            this.lstSayi.TabIndex = 2;
            // 
            // lstVeri
            // 
            this.lstVeri.FormattingEnabled = true;
            this.lstVeri.Location = new System.Drawing.Point(239, 71);
            this.lstVeri.Name = "lstVeri";
            this.lstVeri.Size = new System.Drawing.Size(120, 95);
            this.lstVeri.TabIndex = 3;
            // 
            // frmSayıvs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstVeri);
            this.Controls.Add(this.lstSayi);
            this.Controls.Add(this.txtAlinan);
            this.Controls.Add(this.btnEkle);
            this.Name = "frmSayıvs";
            this.Text = "frmSayıvs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAlinan;
        private System.Windows.Forms.ListBox lstSayi;
        private System.Windows.Forms.ListBox lstVeri;
    }
}