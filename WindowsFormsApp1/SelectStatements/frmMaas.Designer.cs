namespace SelectStatements
{
    partial class frmMaas
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
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.cmbKur = new System.Windows.Forms.ComboBox();
            this.lstMaas = new System.Windows.Forms.ListBox();
            this.lblBrutt = new System.Windows.Forms.Label();
            this.lblBrut = new System.Windows.Forms.Label();
            this.lblİsim = new System.Windows.Forms.Label();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblKur = new System.Windows.Forms.Label();
            this.txtKira = new System.Windows.Forms.TextBox();
            this.txtMutfak = new System.Windows.Forms.TextBox();
            this.txtFatura = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lstBorclu = new System.Windows.Forms.ListBox();
            this.lstBorcsuz = new System.Windows.Forms.ListBox();
            this.lblKurMaas = new System.Windows.Forms.Label();
            this.lblBorc = new System.Windows.Forms.Label();
            this.lblKalan = new System.Windows.Forms.Label();
            this.lblKira = new System.Windows.Forms.Label();
            this.lblFatura = new System.Windows.Forms.Label();
            this.lblMutfak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(66, 44);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(100, 20);
            this.txtİsim.TabIndex = 0;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(66, 80);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(100, 20);
            this.txtMaas.TabIndex = 1;
            // 
            // cmbKur
            // 
            this.cmbKur.FormattingEnabled = true;
            this.cmbKur.Items.AddRange(new object[] {
            "Dolar $",
            "Euro ",
            "Strelin £"});
            this.cmbKur.Location = new System.Drawing.Point(66, 119);
            this.cmbKur.Name = "cmbKur";
            this.cmbKur.Size = new System.Drawing.Size(121, 21);
            this.cmbKur.TabIndex = 2;
            // 
            // lstMaas
            // 
            this.lstMaas.FormattingEnabled = true;
            this.lstMaas.Location = new System.Drawing.Point(326, 44);
            this.lstMaas.Name = "lstMaas";
            this.lstMaas.Size = new System.Drawing.Size(120, 95);
            this.lstMaas.TabIndex = 3;
            // 
            // lblBrutt
            // 
            this.lblBrutt.AutoSize = true;
            this.lblBrutt.Location = new System.Drawing.Point(411, 160);
            this.lblBrutt.Name = "lblBrutt";
            this.lblBrutt.Size = new System.Drawing.Size(35, 13);
            this.lblBrutt.TabIndex = 4;
            this.lblBrutt.Text = "label1";
            // 
            // lblBrut
            // 
            this.lblBrut.AutoSize = true;
            this.lblBrut.Location = new System.Drawing.Point(351, 160);
            this.lblBrut.Name = "lblBrut";
            this.lblBrut.Size = new System.Drawing.Size(57, 13);
            this.lblBrut.TabIndex = 5;
            this.lblBrut.Text = "Brüt maaş:";
            // 
            // lblİsim
            // 
            this.lblİsim.AutoSize = true;
            this.lblİsim.Location = new System.Drawing.Point(13, 50);
            this.lblİsim.Name = "lblİsim";
            this.lblİsim.Size = new System.Drawing.Size(28, 13);
            this.lblİsim.TabIndex = 6;
            this.lblİsim.Text = "İsim:";
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(16, 86);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(36, 13);
            this.lblMaas.TabIndex = 7;
            this.lblMaas.Text = "Maaş:";
            // 
            // lblKur
            // 
            this.lblKur.AutoSize = true;
            this.lblKur.Location = new System.Drawing.Point(16, 127);
            this.lblKur.Name = "lblKur";
            this.lblKur.Size = new System.Drawing.Size(26, 13);
            this.lblKur.TabIndex = 8;
            this.lblKur.Text = "Kur:";
            // 
            // txtKira
            // 
            this.txtKira.Location = new System.Drawing.Point(66, 212);
            this.txtKira.Name = "txtKira";
            this.txtKira.Size = new System.Drawing.Size(100, 20);
            this.txtKira.TabIndex = 9;
            // 
            // txtMutfak
            // 
            this.txtMutfak.Location = new System.Drawing.Point(66, 253);
            this.txtMutfak.Name = "txtMutfak";
            this.txtMutfak.Size = new System.Drawing.Size(100, 20);
            this.txtMutfak.TabIndex = 10;
            // 
            // txtFatura
            // 
            this.txtFatura.Location = new System.Drawing.Point(66, 300);
            this.txtFatura.Name = "txtFatura";
            this.txtFatura.Size = new System.Drawing.Size(100, 20);
            this.txtFatura.TabIndex = 11;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(91, 155);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Add";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(91, 341);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 13;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lstBorclu
            // 
            this.lstBorclu.FormattingEnabled = true;
            this.lstBorclu.Location = new System.Drawing.Point(285, 225);
            this.lstBorclu.Name = "lstBorclu";
            this.lstBorclu.Size = new System.Drawing.Size(120, 95);
            this.lstBorclu.TabIndex = 14;
            // 
            // lstBorcsuz
            // 
            this.lstBorcsuz.FormattingEnabled = true;
            this.lstBorcsuz.Location = new System.Drawing.Point(483, 225);
            this.lstBorcsuz.Name = "lstBorcsuz";
            this.lstBorcsuz.Size = new System.Drawing.Size(120, 95);
            this.lstBorcsuz.TabIndex = 15;
            // 
            // lblKurMaas
            // 
            this.lblKurMaas.AutoSize = true;
            this.lblKurMaas.Location = new System.Drawing.Point(326, 25);
            this.lblKurMaas.Name = "lblKurMaas";
            this.lblKurMaas.Size = new System.Drawing.Size(68, 13);
            this.lblKurMaas.TabIndex = 16;
            this.lblKurMaas.Text = "Ad Maaş Kur";
            // 
            // lblBorc
            // 
            this.lblBorc.AutoSize = true;
            this.lblBorc.Location = new System.Drawing.Point(282, 196);
            this.lblBorc.Name = "lblBorc";
            this.lblBorc.Size = new System.Drawing.Size(37, 13);
            this.lblBorc.TabIndex = 17;
            this.lblBorc.Text = "Borclu";
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Location = new System.Drawing.Point(480, 196);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(55, 13);
            this.lblKalan.TabIndex = 18;
            this.lblKalan.Text = "Borcu yok";
            // 
            // lblKira
            // 
            this.lblKira.AutoSize = true;
            this.lblKira.Location = new System.Drawing.Point(6, 218);
            this.lblKira.Name = "lblKira";
            this.lblKira.Size = new System.Drawing.Size(28, 13);
            this.lblKira.TabIndex = 19;
            this.lblKira.Text = "Kira:";
            // 
            // lblFatura
            // 
            this.lblFatura.AutoSize = true;
            this.lblFatura.Location = new System.Drawing.Point(9, 269);
            this.lblFatura.Name = "lblFatura";
            this.lblFatura.Size = new System.Drawing.Size(40, 13);
            this.lblFatura.TabIndex = 20;
            this.lblFatura.Text = "Fatura:";
            // 
            // lblMutfak
            // 
            this.lblMutfak.AutoSize = true;
            this.lblMutfak.Location = new System.Drawing.Point(8, 306);
            this.lblMutfak.Name = "lblMutfak";
            this.lblMutfak.Size = new System.Drawing.Size(43, 13);
            this.lblMutfak.TabIndex = 21;
            this.lblMutfak.Text = "Mutfak:";
            // 
            // frmMaas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMutfak);
            this.Controls.Add(this.lblFatura);
            this.Controls.Add(this.lblKira);
            this.Controls.Add(this.lblKalan);
            this.Controls.Add(this.lblBorc);
            this.Controls.Add(this.lblKurMaas);
            this.Controls.Add(this.lstBorcsuz);
            this.Controls.Add(this.lstBorclu);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtFatura);
            this.Controls.Add(this.txtMutfak);
            this.Controls.Add(this.txtKira);
            this.Controls.Add(this.lblKur);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.lblİsim);
            this.Controls.Add(this.lblBrut);
            this.Controls.Add(this.lblBrutt);
            this.Controls.Add(this.lstMaas);
            this.Controls.Add(this.cmbKur);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.txtİsim);
            this.Name = "frmMaas";
            this.Text = "frmMaas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.ComboBox cmbKur;
        private System.Windows.Forms.ListBox lstMaas;
        private System.Windows.Forms.Label lblBrutt;
        private System.Windows.Forms.Label lblBrut;
        private System.Windows.Forms.Label lblİsim;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblKur;
        private System.Windows.Forms.TextBox txtKira;
        private System.Windows.Forms.TextBox txtMutfak;
        private System.Windows.Forms.TextBox txtFatura;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.ListBox lstBorclu;
        private System.Windows.Forms.ListBox lstBorcsuz;
        private System.Windows.Forms.Label lblKurMaas;
        private System.Windows.Forms.Label lblBorc;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label lblKira;
        private System.Windows.Forms.Label lblFatura;
        private System.Windows.Forms.Label lblMutfak;
    }
}