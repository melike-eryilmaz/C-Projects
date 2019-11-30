namespace ClassProjects2
{
    partial class frmİslemler
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
            this.chkTopla = new System.Windows.Forms.CheckBox();
            this.chkCikar = new System.Windows.Forms.CheckBox();
            this.chkCarp = new System.Windows.Forms.CheckBox();
            this.chkBol = new System.Windows.Forms.CheckBox();
            this.lstEklenen = new System.Windows.Forms.ListBox();
            this.btnİslem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(59, 85);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(59, 128);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // chkTopla
            // 
            this.chkTopla.AutoSize = true;
            this.chkTopla.Location = new System.Drawing.Point(365, 76);
            this.chkTopla.Name = "chkTopla";
            this.chkTopla.Size = new System.Drawing.Size(49, 17);
            this.chkTopla.TabIndex = 2;
            this.chkTopla.Text = "topla";
            this.chkTopla.UseVisualStyleBackColor = true;
            // 
            // chkCikar
            // 
            this.chkCikar.AutoSize = true;
            this.chkCikar.Location = new System.Drawing.Point(365, 100);
            this.chkCikar.Name = "chkCikar";
            this.chkCikar.Size = new System.Drawing.Size(49, 17);
            this.chkCikar.TabIndex = 3;
            this.chkCikar.Text = "çikar";
            this.chkCikar.UseVisualStyleBackColor = true;
            // 
            // chkCarp
            // 
            this.chkCarp.AutoSize = true;
            this.chkCarp.Location = new System.Drawing.Point(365, 125);
            this.chkCarp.Name = "chkCarp";
            this.chkCarp.Size = new System.Drawing.Size(47, 17);
            this.chkCarp.TabIndex = 4;
            this.chkCarp.Text = "çarp";
            this.chkCarp.UseVisualStyleBackColor = true;
            // 
            // chkBol
            // 
            this.chkBol.AutoSize = true;
            this.chkBol.Location = new System.Drawing.Point(365, 148);
            this.chkBol.Name = "chkBol";
            this.chkBol.Size = new System.Drawing.Size(40, 17);
            this.chkBol.TabIndex = 5;
            this.chkBol.Text = "bol";
            this.chkBol.UseVisualStyleBackColor = true;
            // 
            // lstEklenen
            // 
            this.lstEklenen.FormattingEnabled = true;
            this.lstEklenen.Location = new System.Drawing.Point(210, 76);
            this.lstEklenen.Name = "lstEklenen";
            this.lstEklenen.Size = new System.Drawing.Size(120, 95);
            this.lstEklenen.TabIndex = 6;
            // 
            // btnİslem
            // 
            this.btnİslem.Location = new System.Drawing.Point(503, 100);
            this.btnİslem.Name = "btnİslem";
            this.btnİslem.Size = new System.Drawing.Size(75, 23);
            this.btnİslem.TabIndex = 7;
            this.btnİslem.Text = "islem";
            this.btnİslem.UseVisualStyleBackColor = true;
            this.btnİslem.Click += new System.EventHandler(this.btnİslem_Click);
            // 
            // frmİslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnİslem);
            this.Controls.Add(this.lstEklenen);
            this.Controls.Add(this.chkBol);
            this.Controls.Add(this.chkCarp);
            this.Controls.Add(this.chkCikar);
            this.Controls.Add(this.chkTopla);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSayi);
            this.Name = "frmİslemler";
            this.Text = "frmİslemler";
            this.Load += new System.EventHandler(this.frmİslemler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox chkTopla;
        private System.Windows.Forms.CheckBox chkCikar;
        private System.Windows.Forms.CheckBox chkCarp;
        private System.Windows.Forms.CheckBox chkBol;
        private System.Windows.Forms.ListBox lstEklenen;
        private System.Windows.Forms.Button btnİslem;
    }
}