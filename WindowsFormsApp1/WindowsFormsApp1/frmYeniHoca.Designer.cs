namespace WindowsFormsApp1
{
    partial class frmYeniHoca
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
            this.lstListem = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtEkle = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListem
            // 
            this.lstListem.FormattingEnabled = true;
            this.lstListem.Location = new System.Drawing.Point(78, 52);
            this.lstListem.Name = "lstListem";
            this.lstListem.Size = new System.Drawing.Size(120, 95);
            this.lstListem.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(332, 114);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(319, 62);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(100, 20);
            this.txtEkle.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(319, 13);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(237, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "username";
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Location = new System.Drawing.Point(243, 65);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(47, 13);
            this.lblsurname.TabIndex = 5;
            this.lblsurname.Text = "surname";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(332, 158);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(332, 225);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(75, 23);
            this.btntemizle.TabIndex = 7;
            this.btntemizle.Text = "temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // frmYeniHoca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblsurname);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstListem);
            this.Name = "frmYeniHoca";
            this.Text = "frmYeniHoca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListem;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtEkle;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btntemizle;
    }
}