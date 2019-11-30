namespace SelectStatements
{
    partial class frmMevsim
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
            this.btnMevsim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(209, 104);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 0;
            // 
            // btnMevsim
            // 
            this.btnMevsim.Location = new System.Drawing.Point(209, 162);
            this.btnMevsim.Name = "btnMevsim";
            this.btnMevsim.Size = new System.Drawing.Size(75, 23);
            this.btnMevsim.TabIndex = 1;
            this.btnMevsim.Text = "mevsim";
            this.btnMevsim.UseVisualStyleBackColor = true;
            this.btnMevsim.Click += new System.EventHandler(this.btnMevsim_Click);
            // 
            // frmMevsim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMevsim);
            this.Controls.Add(this.txtSayi);
            this.Name = "frmMevsim";
            this.Text = "frmMevsim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnMevsim;
    }
}