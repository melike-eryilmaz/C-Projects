namespace İterationStatements
{
    partial class frmSearching
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
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lstAranan = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(89, 77);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 20);
            this.txtAdd.TabIndex = 0;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(89, 180);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 20);
            this.txtAra.TabIndex = 1;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(99, 130);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lstAranan
            // 
            this.lstAranan.FormattingEnabled = true;
            this.lstAranan.Location = new System.Drawing.Point(276, 93);
            this.lstAranan.Name = "lstAranan";
            this.lstAranan.Size = new System.Drawing.Size(120, 95);
            this.lstAranan.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(433, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // frmSearching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lstAranan);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtAdd);
            this.Name = "frmSearching";
            this.Text = "frmSearching";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ListBox lstAranan;
        private System.Windows.Forms.ListBox listBox1;
    }
}