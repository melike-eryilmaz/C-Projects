namespace SelectStatements
{
    partial class frmSerhatornek3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblKadın = new System.Windows.Forms.Label();
            this.lblErkek = new System.Windows.Forms.Label();
            this.lblGozluklu = new System.Windows.Forms.Label();
            this.lblGozluksuz = new System.Windows.Forms.Label();
            this.rbKadın = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(69, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(223, 32);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(69, 159);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 2;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(223, 159);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 95);
            this.listBox4.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbErkek);
            this.groupBox1.Controls.Add(this.rbKadın);
            this.groupBox1.Location = new System.Drawing.Point(371, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb2);
            this.groupBox2.Controls.Add(this.rb1);
            this.groupBox2.Location = new System.Drawing.Point(371, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gözlük Durumu";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(633, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(633, 71);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblKadın
            // 
            this.lblKadın.AutoSize = true;
            this.lblKadın.Location = new System.Drawing.Point(13, 49);
            this.lblKadın.Name = "lblKadın";
            this.lblKadın.Size = new System.Drawing.Size(34, 13);
            this.lblKadın.TabIndex = 8;
            this.lblKadın.Text = "Kadın";
            // 
            // lblErkek
            // 
            this.lblErkek.AutoSize = true;
            this.lblErkek.Location = new System.Drawing.Point(16, 170);
            this.lblErkek.Name = "lblErkek";
            this.lblErkek.Size = new System.Drawing.Size(35, 13);
            this.lblErkek.TabIndex = 9;
            this.lblErkek.Text = "Erkek";
            // 
            // lblGozluklu
            // 
            this.lblGozluklu.AutoSize = true;
            this.lblGozluklu.Location = new System.Drawing.Point(116, 13);
            this.lblGozluklu.Name = "lblGozluklu";
            this.lblGozluklu.Size = new System.Drawing.Size(56, 13);
            this.lblGozluklu.TabIndex = 10;
            this.lblGozluklu.Text = "Gözlüksüz";
            // 
            // lblGozluksuz
            // 
            this.lblGozluksuz.AutoSize = true;
            this.lblGozluksuz.Location = new System.Drawing.Point(264, 13);
            this.lblGozluksuz.Name = "lblGozluksuz";
            this.lblGozluksuz.Size = new System.Drawing.Size(48, 13);
            this.lblGozluksuz.TabIndex = 11;
            this.lblGozluksuz.Text = "Gözlüklü";
            // 
            // rbKadın
            // 
            this.rbKadın.AutoSize = true;
            this.rbKadın.Location = new System.Drawing.Point(24, 19);
            this.rbKadın.Name = "rbKadın";
            this.rbKadın.Size = new System.Drawing.Size(52, 17);
            this.rbKadın.TabIndex = 0;
            this.rbKadın.TabStop = true;
            this.rbKadın.Text = "Kadın";
            this.rbKadın.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(24, 54);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 17);
            this.rbErkek.TabIndex = 1;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(24, 44);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(66, 17);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Gözlüklü";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(24, 67);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(74, 17);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "Gözlüksüz";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSerhatornek3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblGozluksuz);
            this.Controls.Add(this.lblGozluklu);
            this.Controls.Add(this.lblErkek);
            this.Controls.Add(this.lblKadın);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "frmSerhatornek3";
            this.Text = "frmSerhatornek3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadın;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblKadın;
        private System.Windows.Forms.Label lblErkek;
        private System.Windows.Forms.Label lblGozluklu;
        private System.Windows.Forms.Label lblGozluksuz;
        private System.Windows.Forms.Button button1;
    }
}