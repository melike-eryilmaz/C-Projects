namespace WindowsFormsApp1
{
    partial class frmBorsa
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
            this.lstPara = new System.Windows.Forms.ListBox();
            this.lstKur = new System.Windows.Forms.ListBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtKur = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPara
            // 
            this.lstPara.FormattingEnabled = true;
            this.lstPara.Location = new System.Drawing.Point(92, 109);
            this.lstPara.Name = "lstPara";
            this.lstPara.Size = new System.Drawing.Size(120, 95);
            this.lstPara.TabIndex = 0;
            this.lstPara.DoubleClick += new System.EventHandler(this.lstPara_DoubleClick);
            // 
            // lstKur
            // 
            this.lstKur.FormattingEnabled = true;
            this.lstKur.Location = new System.Drawing.Point(335, 109);
            this.lstKur.Name = "lstKur";
            this.lstKur.Size = new System.Drawing.Size(120, 95);
            this.lstKur.TabIndex = 1;
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(498, 109);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(100, 20);
            this.txtPara.TabIndex = 2;
            // 
            // txtKur
            // 
            this.txtKur.Location = new System.Drawing.Point(498, 166);
            this.txtKur.Name = "txtKur";
            this.txtKur.Size = new System.Drawing.Size(100, 20);
            this.txtKur.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(498, 268);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(498, 211);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmBorsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtKur);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.lstKur);
            this.Controls.Add(this.lstPara);
            this.Name = "frmBorsa";
            this.Text = "frmBorsa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPara;
        private System.Windows.Forms.ListBox lstKur;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtKur;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
    }
}