namespace SummerCampDatabaseExamples
{
    partial class Form1
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
            this.dgvNotificationList = new System.Windows.Forms.DataGridView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.chked = new System.Windows.Forms.CheckBox();
            this.txted = new System.Windows.Forms.TextBox();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.btndel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificationList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotificationList
            // 
            this.dgvNotificationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificationList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNotificationList.Location = new System.Drawing.Point(0, 249);
            this.dgvNotificationList.Name = "dgvNotificationList";
            this.dgvNotificationList.Size = new System.Drawing.Size(573, 71);
            this.dgvNotificationList.TabIndex = 0;
            this.dgvNotificationList.DoubleClick += new System.EventHandler(this.dgvNotificationList_DoubleClick);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(63, 30);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(63, 67);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(100, 40);
            this.txtDes.TabIndex = 2;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(63, 113);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(80, 17);
            this.chkIsActive.TabIndex = 3;
            this.chkIsActive.Text = "checkBox1";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(68, 141);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(433, 141);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(75, 23);
            this.btnup.TabIndex = 9;
            this.btnup.Text = "update";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // chked
            // 
            this.chked.AutoSize = true;
            this.chked.Location = new System.Drawing.Point(428, 113);
            this.chked.Name = "chked";
            this.chked.Size = new System.Drawing.Size(80, 17);
            this.chked.TabIndex = 8;
            this.chked.Text = "checkBox1";
            this.chked.UseVisualStyleBackColor = true;
            // 
            // txted
            // 
            this.txted.Location = new System.Drawing.Point(428, 67);
            this.txted.Multiline = true;
            this.txted.Name = "txted";
            this.txted.Size = new System.Drawing.Size(100, 40);
            this.txted.TabIndex = 7;
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(428, 30);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(100, 20);
            this.txtEdit.TabIndex = 6;
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(433, 170);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 10;
            this.btndel.Text = "delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 320);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.chked);
            this.Controls.Add(this.txted);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.dgvNotificationList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificationList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotificationList;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.CheckBox chked;
        private System.Windows.Forms.TextBox txted;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Button btndel;
    }
}

