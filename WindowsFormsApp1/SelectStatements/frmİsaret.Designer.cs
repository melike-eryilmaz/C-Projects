namespace SelectStatements
{
    partial class frmİsaret
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
            this.btnİsaret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(150, 108);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 0;
            // 
            // btnİsaret
            // 
            this.btnİsaret.Location = new System.Drawing.Point(166, 161);
            this.btnİsaret.Name = "btnİsaret";
            this.btnİsaret.Size = new System.Drawing.Size(75, 23);
            this.btnİsaret.TabIndex = 1;
            this.btnİsaret.Text = "İsaret";
            this.btnİsaret.UseVisualStyleBackColor = true;
            this.btnİsaret.Click += new System.EventHandler(this.btnİsaret_Click);
            // 
            // frmİsaret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnİsaret);
            this.Controls.Add(this.txtSayi);
            this.Name = "frmİsaret";
            this.Text = "frmİsaret";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnİsaret;
    }
}