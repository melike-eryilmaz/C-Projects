namespace SelectStatements
{
    partial class frmSerhatornek4
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
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.btnHesap = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rbtopla = new System.Windows.Forms.RadioButton();
            this.rbcarp = new System.Windows.Forms.RadioButton();
            this.rbcikar = new System.Windows.Forms.RadioButton();
            this.rbBol = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(98, 57);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(100, 20);
            this.txtsayi1.TabIndex = 0;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(98, 105);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 1;
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(282, 57);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(75, 23);
            this.btnHesap.TabIndex = 2;
            this.btnHesap.Text = "Hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(282, 102);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(98, 210);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // rbtopla
            // 
            this.rbtopla.AutoSize = true;
            this.rbtopla.Location = new System.Drawing.Point(98, 132);
            this.rbtopla.Name = "rbtopla";
            this.rbtopla.Size = new System.Drawing.Size(52, 17);
            this.rbtopla.TabIndex = 5;
            this.rbtopla.TabStop = true;
            this.rbtopla.Text = "Topla";
            this.rbtopla.UseVisualStyleBackColor = true;
            // 
            // rbcarp
            // 
            this.rbcarp.AutoSize = true;
            this.rbcarp.Location = new System.Drawing.Point(98, 165);
            this.rbcarp.Name = "rbcarp";
            this.rbcarp.Size = new System.Drawing.Size(47, 17);
            this.rbcarp.TabIndex = 6;
            this.rbcarp.TabStop = true;
            this.rbcarp.Text = "Çarp";
            this.rbcarp.UseVisualStyleBackColor = true;
            // 
            // rbcikar
            // 
            this.rbcikar.AutoSize = true;
            this.rbcikar.Location = new System.Drawing.Point(230, 132);
            this.rbcikar.Name = "rbcikar";
            this.rbcikar.Size = new System.Drawing.Size(49, 17);
            this.rbcikar.TabIndex = 7;
            this.rbcikar.TabStop = true;
            this.rbcikar.Text = "Çıkar";
            this.rbcikar.UseVisualStyleBackColor = true;
            // 
            // rbBol
            // 
            this.rbBol.AutoSize = true;
            this.rbBol.Location = new System.Drawing.Point(230, 165);
            this.rbBol.Name = "rbBol";
            this.rbBol.Size = new System.Drawing.Size(39, 17);
            this.rbBol.TabIndex = 8;
            this.rbBol.TabStop = true;
            this.rbBol.Text = "bol";
            this.rbBol.UseVisualStyleBackColor = true;
            // 
            // frmSerhatornek4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbBol);
            this.Controls.Add(this.rbcikar);
            this.Controls.Add(this.rbcarp);
            this.Controls.Add(this.rbtopla);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtsayi1);
            this.Name = "frmSerhatornek4";
            this.Text = "frmSerhatornek4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbtopla;
        private System.Windows.Forms.RadioButton rbcarp;
        private System.Windows.Forms.RadioButton rbcikar;
        private System.Windows.Forms.RadioButton rbBol;
    }
}