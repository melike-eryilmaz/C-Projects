namespace SelectStatements
{
    partial class frmSayiString
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
            this.btnCon = new System.Windows.Forms.Button();
            this.lblString = new System.Windows.Forms.Label();
            this.lblSayi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(256, 74);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 0;
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(267, 123);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(75, 23);
            this.btnCon.TabIndex = 1;
            this.btnCon.Text = "Çevir";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(286, 172);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(0, 13);
            this.lblString.TabIndex = 2;
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Location = new System.Drawing.Point(188, 80);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(30, 13);
            this.lblSayi.TabIndex = 3;
            this.lblSayi.Text = "Sayi:";
            // 
            // frmSayiString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.txtSayi);
            this.Name = "frmSayiString";
            this.Text = "frmSayiString";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Label lblSayi;
    }
}