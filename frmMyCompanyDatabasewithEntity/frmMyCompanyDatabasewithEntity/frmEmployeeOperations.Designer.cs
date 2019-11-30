namespace frmMyCompanyDatabasewithEntity
{
    partial class frmEmployeeOperations
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
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.txtEmplooyee2 = new System.Windows.Forms.TextBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(436, 39);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(100, 20);
            this.txtEmployee.TabIndex = 0;
            // 
            // txtEmplooyee2
            // 
            this.txtEmplooyee2.Location = new System.Drawing.Point(436, 85);
            this.txtEmplooyee2.Name = "txtEmplooyee2";
            this.txtEmplooyee2.Size = new System.Drawing.Size(100, 20);
            this.txtEmplooyee2.TabIndex = 1;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(1, 213);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(743, 239);
            this.dgvEmployee.TabIndex = 2;
            // 
            // frmEmployeeOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.txtEmplooyee2);
            this.Controls.Add(this.txtEmployee);
            this.Name = "frmEmployeeOperations";
            this.Text = "frmEmployeeOperaions";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.TextBox txtEmplooyee2;
        private System.Windows.Forms.DataGridView dgvEmployee;
    }
}