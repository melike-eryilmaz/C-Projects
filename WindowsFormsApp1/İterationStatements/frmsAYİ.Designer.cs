namespace İterationStatements
{
    partial class frmsAYİ
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
            this.lst2 = new System.Windows.Forms.ListBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(91, 66);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(120, 95);
            this.lst2.TabIndex = 0;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(329, 66);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(120, 95);
            this.lst1.TabIndex = 1;
            // 
            // frmsAYİ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.lst2);
            this.Name = "frmsAYİ";
            this.Text = "frmsAYİ";
            this.Load += new System.EventHandler(this.frmsAYİ_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.ListBox lst1;
    }
}