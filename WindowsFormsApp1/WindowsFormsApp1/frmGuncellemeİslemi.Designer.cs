namespace WindowsFormsApp1
{
    partial class frmGuncellemeİslemi
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
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstEklenen = new System.Windows.Forms.ListBox();
            this.lstGuncellenen = new System.Windows.Forms.ListBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtGuncelle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(67, 185);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(100, 20);
            this.txtEkle.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(78, 238);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstEklenen
            // 
            this.lstEklenen.FormattingEnabled = true;
            this.lstEklenen.Location = new System.Drawing.Point(67, 66);
            this.lstEklenen.Name = "lstEklenen";
            this.lstEklenen.Size = new System.Drawing.Size(120, 95);
            this.lstEklenen.TabIndex = 2;
            this.lstEklenen.DoubleClick += new System.EventHandler(this.lstEklenen_DoubleClick);
            // 
            // lstGuncellenen
            // 
            this.lstGuncellenen.FormattingEnabled = true;
            this.lstGuncellenen.Location = new System.Drawing.Point(313, 66);
            this.lstGuncellenen.Name = "lstGuncellenen";
            this.lstGuncellenen.Size = new System.Drawing.Size(120, 95);
            this.lstGuncellenen.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(313, 238);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtGuncelle
            // 
            this.txtGuncelle.Location = new System.Drawing.Point(313, 185);
            this.txtGuncelle.Name = "txtGuncelle";
            this.txtGuncelle.Size = new System.Drawing.Size(100, 20);
            this.txtGuncelle.TabIndex = 5;
            // 
            // frmGuncellemeİslemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGuncelle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lstGuncellenen);
            this.Controls.Add(this.lstEklenen);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEkle);
            this.Name = "frmGuncellemeİslemi";
            this.Text = "frmGuncellemeİslemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstEklenen;
        private System.Windows.Forms.ListBox lstGuncellenen;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtGuncelle;
    }
}