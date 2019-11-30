namespace SelectStatements
{
    partial class ifExample4
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
            this.btnOrt = new System.Windows.Forms.Button();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.lstGecenler = new System.Windows.Forms.ListBox();
            this.lstSartlı = new System.Windows.Forms.ListBox();
            this.lstKalanlar = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOrt
            // 
            this.btnOrt.Location = new System.Drawing.Point(92, 150);
            this.btnOrt.Name = "btnOrt";
            this.btnOrt.Size = new System.Drawing.Size(75, 23);
            this.btnOrt.TabIndex = 0;
            this.btnOrt.Text = "Hesapla";
            this.btnOrt.UseVisualStyleBackColor = true;
            this.btnOrt.Click += new System.EventHandler(this.btnOrt_Click);
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(77, 75);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(100, 20);
            this.txtVize.TabIndex = 1;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(77, 112);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 2;
            // 
            // lstGecenler
            // 
            this.lstGecenler.FormattingEnabled = true;
            this.lstGecenler.Location = new System.Drawing.Point(290, 75);
            this.lstGecenler.Name = "lstGecenler";
            this.lstGecenler.Size = new System.Drawing.Size(120, 95);
            this.lstGecenler.TabIndex = 3;
            // 
            // lstSartlı
            // 
            this.lstSartlı.FormattingEnabled = true;
            this.lstSartlı.Location = new System.Drawing.Point(527, 78);
            this.lstSartlı.Name = "lstSartlı";
            this.lstSartlı.Size = new System.Drawing.Size(120, 95);
            this.lstSartlı.TabIndex = 4;
            // 
            // lstKalanlar
            // 
            this.lstKalanlar.FormattingEnabled = true;
            this.lstKalanlar.Location = new System.Drawing.Point(290, 274);
            this.lstKalanlar.Name = "lstKalanlar";
            this.lstKalanlar.Size = new System.Drawing.Size(120, 95);
            this.lstKalanlar.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // ifExample4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstKalanlar);
            this.Controls.Add(this.lstSartlı);
            this.Controls.Add(this.lstGecenler);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.btnOrt);
            this.Name = "ifExample4";
            this.Text = "ifExample4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrt;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.ListBox lstGecenler;
        private System.Windows.Forms.ListBox lstSartlı;
        private System.Windows.Forms.ListBox lstKalanlar;
        private System.Windows.Forms.TextBox textBox1;
    }
}