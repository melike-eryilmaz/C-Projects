namespace İterationStatements
{
    partial class frmOdev1
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
            this.txtEklenen = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstChange = new System.Windows.Forms.ListBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.lblDegisim = new System.Windows.Forms.Label();
            this.chkSame = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtEklenen
            // 
            this.txtEklenen.Location = new System.Drawing.Point(171, 114);
            this.txtEklenen.Name = "txtEklenen";
            this.txtEklenen.Size = new System.Drawing.Size(100, 20);
            this.txtEklenen.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(184, 160);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstChange
            // 
            this.lstChange.FormattingEnabled = true;
            this.lstChange.Location = new System.Drawing.Point(361, 114);
            this.lstChange.Name = "lstChange";
            this.lstChange.Size = new System.Drawing.Size(120, 95);
            this.lstChange.TabIndex = 2;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(376, 259);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnDegistir.TabIndex = 3;
            this.btnDegistir.Text = "Degistir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // lblDegisim
            // 
            this.lblDegisim.AutoSize = true;
            this.lblDegisim.Location = new System.Drawing.Point(373, 226);
            this.lblDegisim.Name = "lblDegisim";
            this.lblDegisim.Size = new System.Drawing.Size(48, 13);
            this.lblDegisim.TabIndex = 4;
            this.lblDegisim.Text = "Degisme";
            // 
            // chkSame
            // 
            this.chkSame.AutoSize = true;
            this.chkSame.Location = new System.Drawing.Point(376, 300);
            this.chkSame.Name = "chkSame";
            this.chkSame.Size = new System.Drawing.Size(53, 17);
            this.chkSame.TabIndex = 5;
            this.chkSame.Text = "Same";
            this.chkSame.UseVisualStyleBackColor = true;
            // 
            // frmOdev1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkSame);
            this.Controls.Add(this.lblDegisim);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.lstChange);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEklenen);
            this.Name = "frmOdev1";
            this.Text = "frmOdev1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEklenen;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstChange;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Label lblDegisim;
        private System.Windows.Forms.CheckBox chkSame;
    }
}