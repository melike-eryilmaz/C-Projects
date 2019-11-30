namespace WindowsFormsApp1
{
    partial class frmSiparis
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
            this.lstMeyve = new System.Windows.Forms.ListBox();
            this.lstFiyat = new System.Windows.Forms.ListBox();
            this.lstSiparis = new System.Windows.Forms.ListBox();
            this.btnArti = new System.Windows.Forms.Button();
            this.btnEksi = new System.Windows.Forms.Button();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.lblHesap = new System.Windows.Forms.Label();
            this.btnHesap = new System.Windows.Forms.Button();
            this.btnYeniSiparis = new System.Windows.Forms.Button();
            this.lblKilo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMeyve
            // 
            this.lstMeyve.FormattingEnabled = true;
            this.lstMeyve.Location = new System.Drawing.Point(100, 90);
            this.lstMeyve.Name = "lstMeyve";
            this.lstMeyve.Size = new System.Drawing.Size(120, 95);
            this.lstMeyve.TabIndex = 0;
            this.lstMeyve.SelectedIndexChanged += new System.EventHandler(this.lstMeyve_SelectedIndexChanged);
            // 
            // lstFiyat
            // 
            this.lstFiyat.Enabled = false;
            this.lstFiyat.FormattingEnabled = true;
            this.lstFiyat.Location = new System.Drawing.Point(259, 90);
            this.lstFiyat.Name = "lstFiyat";
            this.lstFiyat.Size = new System.Drawing.Size(120, 95);
            this.lstFiyat.TabIndex = 1;
            // 
            // lstSiparis
            // 
            this.lstSiparis.FormattingEnabled = true;
            this.lstSiparis.Location = new System.Drawing.Point(559, 90);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(120, 95);
            this.lstSiparis.TabIndex = 2;
            // 
            // btnArti
            // 
            this.btnArti.Location = new System.Drawing.Point(411, 36);
            this.btnArti.Name = "btnArti";
            this.btnArti.Size = new System.Drawing.Size(61, 41);
            this.btnArti.TabIndex = 3;
            this.btnArti.Text = "+";
            this.btnArti.UseVisualStyleBackColor = true;
            this.btnArti.Click += new System.EventHandler(this.btnArti_Click);
            // 
            // btnEksi
            // 
            this.btnEksi.Location = new System.Drawing.Point(411, 191);
            this.btnEksi.Name = "btnEksi";
            this.btnEksi.Size = new System.Drawing.Size(61, 44);
            this.btnEksi.TabIndex = 4;
            this.btnEksi.Text = "-";
            this.btnEksi.UseVisualStyleBackColor = true;
            this.btnEksi.Click += new System.EventHandler(this.btnEksi_Click);
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Location = new System.Drawing.Point(423, 130);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(13, 13);
            this.lblfiyat.TabIndex = 5;
            this.lblfiyat.Text = "0";
            // 
            // lblHesap
            // 
            this.lblHesap.AutoSize = true;
            this.lblHesap.Location = new System.Drawing.Point(604, 207);
            this.lblHesap.Name = "lblHesap";
            this.lblHesap.Size = new System.Drawing.Size(13, 13);
            this.lblHesap.TabIndex = 6;
            this.lblHesap.Text = "0";
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(411, 268);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(75, 23);
            this.btnHesap.TabIndex = 7;
            this.btnHesap.Text = "Hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // btnYeniSiparis
            // 
            this.btnYeniSiparis.Location = new System.Drawing.Point(313, 268);
            this.btnYeniSiparis.Name = "btnYeniSiparis";
            this.btnYeniSiparis.Size = new System.Drawing.Size(75, 23);
            this.btnYeniSiparis.TabIndex = 8;
            this.btnYeniSiparis.Text = "Yeni Sipariş";
            this.btnYeniSiparis.UseVisualStyleBackColor = true;
            this.btnYeniSiparis.Click += new System.EventHandler(this.btnYeniSiparis_Click);
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.Location = new System.Drawing.Point(408, 9);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(31, 13);
            this.lblKilo.TabIndex = 9;
            this.lblKilo.Text = "KİLO";
            // 
            // frmSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.btnYeniSiparis);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.lblHesap);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.btnEksi);
            this.Controls.Add(this.btnArti);
            this.Controls.Add(this.lstSiparis);
            this.Controls.Add(this.lstFiyat);
            this.Controls.Add(this.lstMeyve);
            this.Name = "frmSiparis";
            this.Text = "frmSiparis";
            this.Load += new System.EventHandler(this.frmSiparis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMeyve;
        private System.Windows.Forms.ListBox lstFiyat;
        private System.Windows.Forms.ListBox lstSiparis;
        private System.Windows.Forms.Button btnArti;
        private System.Windows.Forms.Button btnEksi;
        private System.Windows.Forms.Label lblfiyat;
        private System.Windows.Forms.Label lblHesap;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Button btnYeniSiparis;
        private System.Windows.Forms.Label lblKilo;
    }
}