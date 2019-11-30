namespace SelectStatements
{
    partial class frmHelvacıHelva
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
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.chkKilo = new System.Windows.Forms.ComboBox();
            this.txtUrun = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lstAlısveris = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Location = new System.Drawing.Point(63, 72);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(47, 13);
            this.lblUrunAd.TabIndex = 0;
            this.lblUrunAd.Text = "Ürün adı";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(59, 138);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(57, 13);
            this.lblFiyat.TabIndex = 1;
            this.lblFiyat.Text = "Ürün Fiyatı";
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.Location = new System.Drawing.Point(59, 202);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(51, 13);
            this.lblKilo.TabIndex = 3;
            this.lblKilo.Text = "Adet/Kilo";
            // 
            // chkKilo
            // 
            this.chkKilo.FormattingEnabled = true;
            this.chkKilo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.chkKilo.Location = new System.Drawing.Point(57, 227);
            this.chkKilo.Name = "chkKilo";
            this.chkKilo.Size = new System.Drawing.Size(121, 21);
            this.chkKilo.TabIndex = 4;
            // 
            // txtUrun
            // 
            this.txtUrun.Location = new System.Drawing.Point(57, 102);
            this.txtUrun.Name = "txtUrun";
            this.txtUrun.Size = new System.Drawing.Size(100, 20);
            this.txtUrun.TabIndex = 5;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(57, 166);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 7;
            // 
            // lstAlısveris
            // 
            this.lstAlısveris.FormattingEnabled = true;
            this.lstAlısveris.Location = new System.Drawing.Point(392, 102);
            this.lstAlısveris.Name = "lstAlısveris";
            this.lstAlısveris.Size = new System.Drawing.Size(120, 95);
            this.lstAlısveris.TabIndex = 8;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(66, 271);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmHelvacıHelva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstAlısveris);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtUrun);
            this.Controls.Add(this.chkKilo);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblUrunAd);
            this.Name = "frmHelvacıHelva";
            this.Text = "frmHelvacıHelva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.ComboBox chkKilo;
        private System.Windows.Forms.TextBox txtUrun;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.ListBox lstAlısveris;
        private System.Windows.Forms.Button btnEkle;
    }
}