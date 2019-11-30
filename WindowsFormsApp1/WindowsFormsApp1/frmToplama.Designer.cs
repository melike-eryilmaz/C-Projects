namespace WindowsFormsApp1
{
    partial class frmToplama
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
            this.btnTopla = new System.Windows.Forms.Button();
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.lblİkinciSayi = new System.Windows.Forms.Label();
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.txtİkinciSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(246, 162);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(115, 23);
            this.btnTopla.TabIndex = 0;
            this.btnTopla.Text = "HaydiToplaa!";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // lblBirinciSayi
            // 
            this.lblBirinciSayi.AutoSize = true;
            this.lblBirinciSayi.Location = new System.Drawing.Point(175, 67);
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            this.lblBirinciSayi.Size = new System.Drawing.Size(58, 13);
            this.lblBirinciSayi.TabIndex = 1;
            this.lblBirinciSayi.Text = "Birinci Sayı";
            // 
            // lblİkinciSayi
            // 
            this.lblİkinciSayi.AutoSize = true;
            this.lblİkinciSayi.Location = new System.Drawing.Point(175, 101);
            this.lblİkinciSayi.Name = "lblİkinciSayi";
            this.lblİkinciSayi.Size = new System.Drawing.Size(55, 13);
            this.lblİkinciSayi.TabIndex = 2;
            this.lblİkinciSayi.Text = "İkinci Sayi";
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Location = new System.Drawing.Point(246, 60);
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txtBirinciSayi.TabIndex = 3;
            // 
            // txtİkinciSayi
            // 
            this.txtİkinciSayi.Location = new System.Drawing.Point(246, 98);
            this.txtİkinciSayi.Name = "txtİkinciSayi";
            this.txtİkinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txtİkinciSayi.TabIndex = 4;
            // 
            // frmToplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.txtİkinciSayi);
            this.Controls.Add(this.txtBirinciSayi);
            this.Controls.Add(this.lblİkinciSayi);
            this.Controls.Add(this.lblBirinciSayi);
            this.Controls.Add(this.btnTopla);
            this.Name = "frmToplama";
            this.Text = "frmToplama";
            this.Load += new System.EventHandler(this.frmToplama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Label lblBirinciSayi;
        private System.Windows.Forms.Label lblİkinciSayi;
        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.TextBox txtİkinciSayi;
    }
}