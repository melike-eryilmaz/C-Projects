namespace İterationStatements
{
    partial class frmSearch
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
            this.txtEklenen = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lstEklenen = new System.Windows.Forms.ListBox();
            this.lstBulunan = new System.Windows.Forms.ListBox();
            this.lstBulunmayan = new System.Windows.Forms.ListBox();
            this.lstİceren = new System.Windows.Forms.ListBox();
            this.Eklenen = new System.Windows.Forms.Label();
            this.Bulunan = new System.Windows.Forms.Label();
            this.Bulunamayan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEklenen
            // 
            this.txtEklenen.Location = new System.Drawing.Point(48, 72);
            this.txtEklenen.Name = "txtEklenen";
            this.txtEklenen.Size = new System.Drawing.Size(100, 20);
            this.txtEklenen.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(64, 123);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Add";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(48, 191);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(100, 20);
            this.txtAranan.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(64, 247);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "Search";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // lstEklenen
            // 
            this.lstEklenen.FormattingEnabled = true;
            this.lstEklenen.Location = new System.Drawing.Point(194, 72);
            this.lstEklenen.Name = "lstEklenen";
            this.lstEklenen.Size = new System.Drawing.Size(120, 95);
            this.lstEklenen.TabIndex = 4;
            // 
            // lstBulunan
            // 
            this.lstBulunan.FormattingEnabled = true;
            this.lstBulunan.Location = new System.Drawing.Point(360, 72);
            this.lstBulunan.Name = "lstBulunan";
            this.lstBulunan.Size = new System.Drawing.Size(120, 95);
            this.lstBulunan.TabIndex = 5;
            // 
            // lstBulunmayan
            // 
            this.lstBulunmayan.FormattingEnabled = true;
            this.lstBulunmayan.Location = new System.Drawing.Point(517, 72);
            this.lstBulunmayan.Name = "lstBulunmayan";
            this.lstBulunmayan.Size = new System.Drawing.Size(120, 95);
            this.lstBulunmayan.TabIndex = 6;
            // 
            // lstİceren
            // 
            this.lstİceren.FormattingEnabled = true;
            this.lstİceren.Location = new System.Drawing.Point(668, 72);
            this.lstİceren.Name = "lstİceren";
            this.lstİceren.Size = new System.Drawing.Size(120, 95);
            this.lstİceren.TabIndex = 7;
            // 
            // Eklenen
            // 
            this.Eklenen.AutoSize = true;
            this.Eklenen.Location = new System.Drawing.Point(211, 37);
            this.Eklenen.Name = "Eklenen";
            this.Eklenen.Size = new System.Drawing.Size(57, 13);
            this.Eklenen.TabIndex = 8;
            this.Eklenen.Text = "EKLENEN";
            // 
            // Bulunan
            // 
            this.Bulunan.AutoSize = true;
            this.Bulunan.Location = new System.Drawing.Point(407, 36);
            this.Bulunan.Name = "Bulunan";
            this.Bulunan.Size = new System.Drawing.Size(59, 13);
            this.Bulunan.TabIndex = 9;
            this.Bulunan.Text = "BULUNAN";
            // 
            // Bulunamayan
            // 
            this.Bulunamayan.AutoSize = true;
            this.Bulunamayan.Location = new System.Drawing.Point(575, 37);
            this.Bulunamayan.Name = "Bulunamayan";
            this.Bulunamayan.Size = new System.Drawing.Size(89, 13);
            this.Bulunamayan.TabIndex = 10;
            this.Bulunamayan.Text = "BULUNAMAYAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "İÇEREN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(695, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "0";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Bulunamayan);
            this.Controls.Add(this.Bulunan);
            this.Controls.Add(this.Eklenen);
            this.Controls.Add(this.lstİceren);
            this.Controls.Add(this.lstBulunmayan);
            this.Controls.Add(this.lstBulunan);
            this.Controls.Add(this.lstEklenen);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEklenen);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEklenen;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ListBox lstEklenen;
        private System.Windows.Forms.ListBox lstBulunan;
        private System.Windows.Forms.ListBox lstBulunmayan;
        private System.Windows.Forms.ListBox lstİceren;
        private System.Windows.Forms.Label Eklenen;
        private System.Windows.Forms.Label Bulunan;
        private System.Windows.Forms.Label Bulunamayan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}