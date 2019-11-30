namespace SelectStatements
{
    partial class frmBirazdaoyun
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
            this.btnEsitmi = new System.Windows.Forms.Button();
            this.btnYenioyun = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEsitmi
            // 
            this.btnEsitmi.Enabled = false;
            this.btnEsitmi.Location = new System.Drawing.Point(47, 101);
            this.btnEsitmi.Name = "btnEsitmi";
            this.btnEsitmi.Size = new System.Drawing.Size(75, 23);
            this.btnEsitmi.TabIndex = 0;
            this.btnEsitmi.Text = "Dogru mu";
            this.btnEsitmi.UseVisualStyleBackColor = true;
            this.btnEsitmi.Click += new System.EventHandler(this.btnEsitmi_Click);
            // 
            // btnYenioyun
            // 
            this.btnYenioyun.Location = new System.Drawing.Point(47, 155);
            this.btnYenioyun.Name = "btnYenioyun";
            this.btnYenioyun.Size = new System.Drawing.Size(75, 23);
            this.btnYenioyun.TabIndex = 1;
            this.btnYenioyun.Text = "yeni oyun";
            this.btnYenioyun.UseVisualStyleBackColor = true;
            this.btnYenioyun.Click += new System.EventHandler(this.btnYenioyun_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(261, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            // 
            // txtSayi
            // 
            this.txtSayi.Enabled = false;
            this.txtSayi.Location = new System.Drawing.Point(47, 47);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 3;
            // 
            // frmBirazdaoyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnYenioyun);
            this.Controls.Add(this.btnEsitmi);
            this.Name = "frmBirazdaoyun";
            this.Text = "frmBirazdaoyun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEsitmi;
        private System.Windows.Forms.Button btnYenioyun;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtSayi;
    }
}