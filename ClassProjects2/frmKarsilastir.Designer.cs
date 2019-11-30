namespace ClassProjects2
{
    partial class frmKarsilastir
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
            this.txtList1Baslangic = new System.Windows.Forms.TextBox();
            this.txtList2Bitis = new System.Windows.Forms.TextBox();
            this.txtList2Baslangic = new System.Windows.Forms.TextBox();
            this.txtList1Bitis = new System.Windows.Forms.TextBox();
            this.btnKarsilastir = new System.Windows.Forms.Button();
            this.lstAynı = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtList1Baslangic
            // 
            this.txtList1Baslangic.Location = new System.Drawing.Point(88, 50);
            this.txtList1Baslangic.Name = "txtList1Baslangic";
            this.txtList1Baslangic.Size = new System.Drawing.Size(100, 20);
            this.txtList1Baslangic.TabIndex = 0;
            // 
            // txtList2Bitis
            // 
            this.txtList2Bitis.Location = new System.Drawing.Point(368, 76);
            this.txtList2Bitis.Name = "txtList2Bitis";
            this.txtList2Bitis.Size = new System.Drawing.Size(100, 20);
            this.txtList2Bitis.TabIndex = 1;
            // 
            // txtList2Baslangic
            // 
            this.txtList2Baslangic.Location = new System.Drawing.Point(368, 50);
            this.txtList2Baslangic.Name = "txtList2Baslangic";
            this.txtList2Baslangic.Size = new System.Drawing.Size(100, 20);
            this.txtList2Baslangic.TabIndex = 2;
            // 
            // txtList1Bitis
            // 
            this.txtList1Bitis.Location = new System.Drawing.Point(88, 76);
            this.txtList1Bitis.Name = "txtList1Bitis";
            this.txtList1Bitis.Size = new System.Drawing.Size(100, 20);
            this.txtList1Bitis.TabIndex = 3;
            // 
            // btnKarsilastir
            // 
            this.btnKarsilastir.Location = new System.Drawing.Point(234, 60);
            this.btnKarsilastir.Name = "btnKarsilastir";
            this.btnKarsilastir.Size = new System.Drawing.Size(75, 23);
            this.btnKarsilastir.TabIndex = 4;
            this.btnKarsilastir.Text = "Karşılaştır";
            this.btnKarsilastir.UseVisualStyleBackColor = true;
            this.btnKarsilastir.Click += new System.EventHandler(this.btnKarsilastir_Click);
            // 
            // lstAynı
            // 
            this.lstAynı.FormattingEnabled = true;
            this.lstAynı.Location = new System.Drawing.Point(220, 142);
            this.lstAynı.Name = "lstAynı";
            this.lstAynı.Size = new System.Drawing.Size(120, 95);
            this.lstAynı.TabIndex = 5;
            // 
            // frmKarsilastir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAynı);
            this.Controls.Add(this.btnKarsilastir);
            this.Controls.Add(this.txtList1Bitis);
            this.Controls.Add(this.txtList2Baslangic);
            this.Controls.Add(this.txtList2Bitis);
            this.Controls.Add(this.txtList1Baslangic);
            this.Name = "frmKarsilastir";
            this.Text = "frmKarsilastir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtList1Baslangic;
        private System.Windows.Forms.TextBox txtList2Bitis;
        private System.Windows.Forms.TextBox txtList2Baslangic;
        private System.Windows.Forms.TextBox txtList1Bitis;
        private System.Windows.Forms.Button btnKarsilastir;
        private System.Windows.Forms.ListBox lstAynı;
    }
}