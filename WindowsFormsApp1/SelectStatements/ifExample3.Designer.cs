namespace SelectStatements
{
    partial class ifExample3
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
            this.txtVize = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lstGecenler = new System.Windows.Forms.ListBox();
            this.lstKalanlar = new System.Windows.Forms.ListBox();
            this.btnOrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(95, 47);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(100, 20);
            this.txtVize.TabIndex = 0;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(95, 87);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(95, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 2;
            // 
            // lstGecenler
            // 
            this.lstGecenler.FormattingEnabled = true;
            this.lstGecenler.Location = new System.Drawing.Point(291, 12);
            this.lstGecenler.Name = "lstGecenler";
            this.lstGecenler.Size = new System.Drawing.Size(371, 95);
            this.lstGecenler.TabIndex = 3;
            // 
            // lstKalanlar
            // 
            this.lstKalanlar.FormattingEnabled = true;
            this.lstKalanlar.Location = new System.Drawing.Point(291, 140);
            this.lstKalanlar.Name = "lstKalanlar";
            this.lstKalanlar.Size = new System.Drawing.Size(371, 95);
            this.lstKalanlar.TabIndex = 4;
            // 
            // btnOrt
            // 
            this.btnOrt.Location = new System.Drawing.Point(120, 140);
            this.btnOrt.Name = "btnOrt";
            this.btnOrt.Size = new System.Drawing.Size(75, 23);
            this.btnOrt.TabIndex = 5;
            this.btnOrt.Text = "Ortalama Hesapla";
            this.btnOrt.UseVisualStyleBackColor = true;
            this.btnOrt.Click += new System.EventHandler(this.btnOrt_Click);
            // 
            // ifExample3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 393);
            this.Controls.Add(this.btnOrt);
            this.Controls.Add(this.lstKalanlar);
            this.Controls.Add(this.lstGecenler);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVize);
            this.Name = "ifExample3";
            this.Text = "ifExample3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ListBox lstGecenler;
        private System.Windows.Forms.ListBox lstKalanlar;
        private System.Windows.Forms.Button btnOrt;
    }
}