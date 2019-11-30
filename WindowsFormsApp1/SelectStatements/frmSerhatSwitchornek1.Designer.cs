namespace SelectStatements
{
    partial class frmSerhatSwitchornek1
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
            this.btnSorgu = new System.Windows.Forms.Button();
            this.lstCift = new System.Windows.Forms.ListBox();
            this.lstTek = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(119, 50);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 0;
            // 
            // btnSorgu
            // 
            this.btnSorgu.Location = new System.Drawing.Point(119, 102);
            this.btnSorgu.Name = "btnSorgu";
            this.btnSorgu.Size = new System.Drawing.Size(75, 23);
            this.btnSorgu.TabIndex = 1;
            this.btnSorgu.Text = "sorgula";
            this.btnSorgu.UseVisualStyleBackColor = true;
            this.btnSorgu.Click += new System.EventHandler(this.btnSorgu_Click);
            // 
            // lstCift
            // 
            this.lstCift.FormattingEnabled = true;
            this.lstCift.Location = new System.Drawing.Point(21, 159);
            this.lstCift.Name = "lstCift";
            this.lstCift.Size = new System.Drawing.Size(120, 95);
            this.lstCift.TabIndex = 2;
            // 
            // lstTek
            // 
            this.lstTek.FormattingEnabled = true;
            this.lstTek.Location = new System.Drawing.Point(241, 159);
            this.lstTek.Name = "lstTek";
            this.lstTek.Size = new System.Drawing.Size(120, 95);
            this.lstTek.TabIndex = 3;
            // 
            // frmSerhatSwitchornek1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 341);
            this.Controls.Add(this.lstTek);
            this.Controls.Add(this.lstCift);
            this.Controls.Add(this.btnSorgu);
            this.Controls.Add(this.txtSayi);
            this.Name = "frmSerhatSwitchornek1";
            this.Text = "frmSerhatSwitchornek1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnSorgu;
        private System.Windows.Forms.ListBox lstCift;
        private System.Windows.Forms.ListBox lstTek;
    }
}