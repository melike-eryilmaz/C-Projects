namespace WindowsFormsApp1
{
    partial class frmBolme
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
            this.btnBol = new System.Windows.Forms.Button();
            this.txtİkinciSayi = new System.Windows.Forms.TextBox();
            this.txtBirinciSayi = new System.Windows.Forms.TextBox();
            this.lblİkinciSayi = new System.Windows.Forms.Label();
            this.lblBirinciSayi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(215, 262);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(75, 23);
            this.btnBol.TabIndex = 9;
            this.btnBol.Text = "Haydi Böl!";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // txtİkinciSayi
            // 
            this.txtİkinciSayi.Location = new System.Drawing.Point(215, 185);
            this.txtİkinciSayi.Name = "txtİkinciSayi";
            this.txtİkinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txtİkinciSayi.TabIndex = 8;
            // 
            // txtBirinciSayi
            // 
            this.txtBirinciSayi.Location = new System.Drawing.Point(215, 102);
            this.txtBirinciSayi.Name = "txtBirinciSayi";
            this.txtBirinciSayi.Size = new System.Drawing.Size(100, 20);
            this.txtBirinciSayi.TabIndex = 7;
            // 
            // lblİkinciSayi
            // 
            this.lblİkinciSayi.AutoSize = true;
            this.lblİkinciSayi.Location = new System.Drawing.Point(113, 185);
            this.lblİkinciSayi.Name = "lblİkinciSayi";
            this.lblİkinciSayi.Size = new System.Drawing.Size(55, 13);
            this.lblİkinciSayi.TabIndex = 6;
            this.lblİkinciSayi.Text = "İkinci Sayi";
            // 
            // lblBirinciSayi
            // 
            this.lblBirinciSayi.AutoSize = true;
            this.lblBirinciSayi.Location = new System.Drawing.Point(113, 109);
            this.lblBirinciSayi.Name = "lblBirinciSayi";
            this.lblBirinciSayi.Size = new System.Drawing.Size(58, 13);
            this.lblBirinciSayi.TabIndex = 5;
            this.lblBirinciSayi.Text = "Birinci Sayi";
            // 
            // frmBolme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.txtİkinciSayi);
            this.Controls.Add(this.txtBirinciSayi);
            this.Controls.Add(this.lblİkinciSayi);
            this.Controls.Add(this.lblBirinciSayi);
            this.Name = "frmBolme";
            this.Text = "frmBolme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.TextBox txtİkinciSayi;
        private System.Windows.Forms.TextBox txtBirinciSayi;
        private System.Windows.Forms.Label lblİkinciSayi;
        private System.Windows.Forms.Label lblBirinciSayi;
    }
}