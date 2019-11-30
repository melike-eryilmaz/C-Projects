namespace WindowsFormsApp1
{
    partial class frmConvertExample
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
            this.frmAddButton = new System.Windows.Forms.Button();
            this.lblsayi1 = new System.Windows.Forms.Label();
            this.lblsayi2 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // frmAddButton
            // 
            this.frmAddButton.Location = new System.Drawing.Point(456, 259);
            this.frmAddButton.Name = "frmAddButton";
            this.frmAddButton.Size = new System.Drawing.Size(75, 23);
            this.frmAddButton.TabIndex = 0;
            this.frmAddButton.Text = "topla";
            this.frmAddButton.UseVisualStyleBackColor = true;
            this.frmAddButton.Click += new System.EventHandler(this.frmAddButton_Click);
            // 
            // lblsayi1
            // 
            this.lblsayi1.AutoSize = true;
            this.lblsayi1.Location = new System.Drawing.Point(348, 133);
            this.lblsayi1.Name = "lblsayi1";
            this.lblsayi1.Size = new System.Drawing.Size(31, 13);
            this.lblsayi1.TabIndex = 1;
            this.lblsayi1.Text = "sayi1";
            // 
            // lblsayi2
            // 
            this.lblsayi2.AutoSize = true;
            this.lblsayi2.Location = new System.Drawing.Point(351, 193);
            this.lblsayi2.Name = "lblsayi2";
            this.lblsayi2.Size = new System.Drawing.Size(31, 13);
            this.lblsayi2.TabIndex = 2;
            this.lblsayi2.Text = "sayi2";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(431, 133);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(100, 20);
            this.txtSayi1.TabIndex = 3;
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(431, 186);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 20);
            this.txtSayi2.TabIndex = 4;
            // 
            // frmConvertExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.lblsayi2);
            this.Controls.Add(this.lblsayi1);
            this.Controls.Add(this.frmAddButton);
            this.Name = "frmConvertExample";
            this.Text = "frmConvertExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmAddButton;
        private System.Windows.Forms.Label lblsayi1;
        private System.Windows.Forms.Label lblsayi2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi2;
    }
}