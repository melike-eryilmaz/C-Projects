namespace WindowsFormsApp1
{
    partial class frmHarikaHesapMakinesi
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
            this.lblDe = new System.Windows.Forms.Label();
            this.lblDeger = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnTopla = new System.Windows.Forms.Button();
            this.txtİkinciSayi = new System.Windows.Forms.TextBox();
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.lblİki = new System.Windows.Forms.Label();
            this.lblBir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(318, 182);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(34, 13);
            this.lblDe.TabIndex = 23;
            this.lblDe.Text = ".........";
            this.lblDe.Click += new System.EventHandler(this.lblDe_Click);
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Location = new System.Drawing.Point(398, 218);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(0, 13);
            this.lblDeger.TabIndex = 22;
            this.lblDeger.Click += new System.EventHandler(this.lblDeger_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(160, 182);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(38, 13);
            this.lblSonuc.TabIndex = 21;
            this.lblSonuc.Text = "Sonuc";
            this.lblSonuc.Click += new System.EventHandler(this.lblSonuc_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.Location = new System.Drawing.Point(373, 334);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(87, 23);
            this.btnCikis.TabIndex = 20;
            this.btnCikis.Text = "Çık";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(584, 254);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(87, 23);
            this.btnCarp.TabIndex = 19;
            this.btnCarp.Text = "Çarp";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(461, 254);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(87, 23);
            this.btnBol.TabIndex = 18;
            this.btnBol.Text = "Böl";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(292, 254);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(87, 23);
            this.btnCikar.TabIndex = 17;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(130, 254);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(87, 23);
            this.btnTopla.TabIndex = 16;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // txtİkinciSayi
            // 
            this.txtİkinciSayi.Location = new System.Drawing.Point(292, 138);
            this.txtİkinciSayi.Name = "txtİkinciSayi";
            this.txtİkinciSayi.Size = new System.Drawing.Size(116, 20);
            this.txtİkinciSayi.TabIndex = 15;
            this.txtİkinciSayi.TextChanged += new System.EventHandler(this.txtİkinciSayi_TextChanged);
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Location = new System.Drawing.Point(292, 94);
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.Size = new System.Drawing.Size(116, 20);
            this.txtBirinciSayi.TabIndex = 14;
            this.txtBirinciSayi.TextChanged += new System.EventHandler(this.txtBirinciSayi_TextChanged);
            // 
            // lblİki
            // 
            this.lblİki.AutoSize = true;
            this.lblİki.Location = new System.Drawing.Point(160, 138);
            this.lblİki.Name = "lblİki";
            this.lblİki.Size = new System.Drawing.Size(55, 13);
            this.lblİki.TabIndex = 13;
            this.lblİki.Text = "İkinci Sayı";
            this.lblİki.Click += new System.EventHandler(this.lblİki_Click);
            // 
            // lblBir
            // 
            this.lblBir.AutoSize = true;
            this.lblBir.Location = new System.Drawing.Point(160, 94);
            this.lblBir.Name = "lblBir";
            this.lblBir.Size = new System.Drawing.Size(58, 13);
            this.lblBir.TabIndex = 12;
            this.lblBir.Text = "Birinci Sayi";
            this.lblBir.Click += new System.EventHandler(this.lblBir_Click);
            // 
            // frmHarikaHesapMakinesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.lblDeger);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.txtİkinciSayi);
            this.Controls.Add(this.txtBirinciSayi);
            this.Controls.Add(this.lblİki);
            this.Controls.Add(this.lblBir);
            this.Name = "frmHarikaHesapMakinesi";
            this.Text = "frmHarikaHesapMakinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblDeger;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.TextBox txtİkinciSayi;
        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.Label lblİki;
        private System.Windows.Forms.Label lblBir;
    }
}