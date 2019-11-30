namespace WindowsFormsApp1
{
    partial class frmHesapMakinesi
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
            this.lblBir = new System.Windows.Forms.Label();
            this.lblİki = new System.Windows.Forms.Label();
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.txtİkinciSayi = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblDeger = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBir
            // 
            this.lblBir.AutoSize = true;
            this.lblBir.Location = new System.Drawing.Point(58, 73);
            this.lblBir.Name = "lblBir";
            this.lblBir.Size = new System.Drawing.Size(70, 13);
            this.lblBir.TabIndex = 0;
            this.lblBir.Text = "Birinci Sayi";
            // 
            // lblİki
            // 
            this.lblİki.AutoSize = true;
            this.lblİki.Location = new System.Drawing.Point(58, 117);
            this.lblİki.Name = "lblİki";
            this.lblİki.Size = new System.Drawing.Size(66, 13);
            this.lblİki.TabIndex = 1;
            this.lblİki.Text = "İkinci Sayı";
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Location = new System.Drawing.Point(190, 73);
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.Size = new System.Drawing.Size(116, 20);
            this.txtBirinciSayi.TabIndex = 2;
            // 
            // txtİkinciSayi
            // 
            this.txtİkinciSayi.Location = new System.Drawing.Point(190, 117);
            this.txtİkinciSayi.Name = "txtİkinciSayi";
            this.txtİkinciSayi.Size = new System.Drawing.Size(116, 20);
            this.txtİkinciSayi.TabIndex = 3;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(28, 233);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(87, 23);
            this.btnTopla.TabIndex = 4;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(190, 233);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(87, 23);
            this.btnCikar.TabIndex = 5;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(359, 233);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(87, 23);
            this.btnBol.TabIndex = 6;
            this.btnBol.Text = "Böl";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(482, 233);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(87, 23);
            this.btnCarp.TabIndex = 7;
            this.btnCarp.Text = "Çarp";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCikis.Location = new System.Drawing.Point(271, 313);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(87, 23);
            this.btnCikis.TabIndex = 8;
            this.btnCikis.Text = "Çık";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(58, 161);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(43, 13);
            this.lblSonuc.TabIndex = 9;
            this.lblSonuc.Text = "Sonuc";
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Location = new System.Drawing.Point(296, 197);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(0, 13);
            this.lblDeger.TabIndex = 10;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(216, 161);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(43, 13);
            this.lblDe.TabIndex = 11;
            this.lblDe.Text = ".........";
            // 
            // frmHesapMakinesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.btnCikis;
            this.ClientSize = new System.Drawing.Size(933, 450);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "frmHesapMakinesi";
            this.Text = "frmHesapMakinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBir;
        private System.Windows.Forms.Label lblİki;
        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.TextBox txtİkinciSayi;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblDeger;
        private System.Windows.Forms.Label lblDe;
    }
}