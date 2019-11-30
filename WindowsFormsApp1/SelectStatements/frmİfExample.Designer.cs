namespace SelectStatements
{
    partial class frmİfExample
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
            this.chkLeftListBox = new System.Windows.Forms.CheckBox();
            this.chkRightListBox = new System.Windows.Forms.CheckBox();
            this.lstLeft = new System.Windows.Forms.ListBox();
            this.lstRight = new System.Windows.Forms.ListBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkLeftListBox
            // 
            this.chkLeftListBox.AutoSize = true;
            this.chkLeftListBox.Location = new System.Drawing.Point(117, 72);
            this.chkLeftListBox.Name = "chkLeftListBox";
            this.chkLeftListBox.Size = new System.Drawing.Size(44, 17);
            this.chkLeftListBox.TabIndex = 0;
            this.chkLeftListBox.Text = "Left";
            this.chkLeftListBox.UseVisualStyleBackColor = true;
            // 
            // chkRightListBox
            // 
            this.chkRightListBox.AutoSize = true;
            this.chkRightListBox.Location = new System.Drawing.Point(190, 72);
            this.chkRightListBox.Name = "chkRightListBox";
            this.chkRightListBox.Size = new System.Drawing.Size(51, 17);
            this.chkRightListBox.TabIndex = 1;
            this.chkRightListBox.Text = "Right";
            this.chkRightListBox.UseVisualStyleBackColor = true;
            // 
            // lstLeft
            // 
            this.lstLeft.FormattingEnabled = true;
            this.lstLeft.Location = new System.Drawing.Point(267, 72);
            this.lstLeft.Name = "lstLeft";
            this.lstLeft.Size = new System.Drawing.Size(120, 95);
            this.lstLeft.TabIndex = 2;
            // 
            // lstRight
            // 
            this.lstRight.FormattingEnabled = true;
            this.lstRight.Location = new System.Drawing.Point(432, 72);
            this.lstRight.Name = "lstRight";
            this.lstRight.Size = new System.Drawing.Size(120, 95);
            this.lstRight.TabIndex = 3;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(117, 147);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 4;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(117, 211);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "Add";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // frmİfExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lstRight);
            this.Controls.Add(this.lstLeft);
            this.Controls.Add(this.chkRightListBox);
            this.Controls.Add(this.chkLeftListBox);
            this.Name = "frmİfExample";
            this.Text = "frmİfExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLeftListBox;
        private System.Windows.Forms.CheckBox chkRightListBox;
        private System.Windows.Forms.ListBox lstLeft;
        private System.Windows.Forms.ListBox lstRight;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn1;
    }
}