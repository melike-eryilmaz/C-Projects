namespace SelectStatements
{
    partial class frmKrediKart
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
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.cmbKur = new System.Windows.Forms.ComboBox();
            this.rbKredi = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.rbWord = new System.Windows.Forms.RadioButton();
            this.rbAccess = new System.Windows.Forms.RadioButton();
            this.rbBonus = new System.Windows.Forms.RadioButton();
            this.rbTek = new System.Windows.Forms.RadioButton();
            this.rbTaksit = new System.Windows.Forms.RadioButton();
            this.cmbTaksit = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstEklenen = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNakit = new System.Windows.Forms.Label();
            this.lblTaksit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(27, 12);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(100, 20);
            this.txtİsim.TabIndex = 0;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(27, 66);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(100, 20);
            this.txtMaas.TabIndex = 1;
            // 
            // cmbKur
            // 
            this.cmbKur.FormattingEnabled = true;
            this.cmbKur.Items.AddRange(new object[] {
            "euro",
            "dolar",
            "sterlin"});
            this.cmbKur.Location = new System.Drawing.Point(27, 118);
            this.cmbKur.Name = "cmbKur";
            this.cmbKur.Size = new System.Drawing.Size(121, 21);
            this.cmbKur.TabIndex = 2;
            // 
            // rbKredi
            // 
            this.rbKredi.AutoSize = true;
            this.rbKredi.Location = new System.Drawing.Point(24, 20);
            this.rbKredi.Name = "rbKredi";
            this.rbKredi.Size = new System.Drawing.Size(73, 17);
            this.rbKredi.TabIndex = 3;
            this.rbKredi.TabStop = true;
            this.rbKredi.Text = "Kredi Kartı";
            this.rbKredi.UseVisualStyleBackColor = true;
            this.rbKredi.CheckedChanged += new System.EventHandler(this.rbKredi_CheckedChanged);
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Location = new System.Drawing.Point(24, 43);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(50, 17);
            this.rbNakit.TabIndex = 4;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
            // 
            // rbWord
            // 
            this.rbWord.AutoSize = true;
            this.rbWord.Enabled = false;
            this.rbWord.Location = new System.Drawing.Point(46, 28);
            this.rbWord.Name = "rbWord";
            this.rbWord.Size = new System.Drawing.Size(51, 17);
            this.rbWord.TabIndex = 5;
            this.rbWord.TabStop = true;
            this.rbWord.Text = "Word";
            this.rbWord.UseVisualStyleBackColor = true;
            this.rbWord.CheckedChanged += new System.EventHandler(this.rbWord_CheckedChanged);
            // 
            // rbAccess
            // 
            this.rbAccess.AutoSize = true;
            this.rbAccess.Enabled = false;
            this.rbAccess.Location = new System.Drawing.Point(44, 51);
            this.rbAccess.Name = "rbAccess";
            this.rbAccess.Size = new System.Drawing.Size(60, 17);
            this.rbAccess.TabIndex = 6;
            this.rbAccess.TabStop = true;
            this.rbAccess.Text = "Access";
            this.rbAccess.UseVisualStyleBackColor = true;
            this.rbAccess.CheckedChanged += new System.EventHandler(this.rbAccess_CheckedChanged);
            // 
            // rbBonus
            // 
            this.rbBonus.AutoSize = true;
            this.rbBonus.Enabled = false;
            this.rbBonus.Location = new System.Drawing.Point(44, 77);
            this.rbBonus.Name = "rbBonus";
            this.rbBonus.Size = new System.Drawing.Size(55, 17);
            this.rbBonus.TabIndex = 7;
            this.rbBonus.TabStop = true;
            this.rbBonus.Text = "Bonus";
            this.rbBonus.UseVisualStyleBackColor = true;
            this.rbBonus.CheckedChanged += new System.EventHandler(this.rbBonus_CheckedChanged);
            // 
            // rbTek
            // 
            this.rbTek.AutoSize = true;
            this.rbTek.Enabled = false;
            this.rbTek.Location = new System.Drawing.Point(39, 32);
            this.rbTek.Name = "rbTek";
            this.rbTek.Size = new System.Drawing.Size(75, 17);
            this.rbTek.TabIndex = 8;
            this.rbTek.TabStop = true;
            this.rbTek.Text = "Tek çekim";
            this.rbTek.UseVisualStyleBackColor = true;
            // 
            // rbTaksit
            // 
            this.rbTaksit.AutoSize = true;
            this.rbTaksit.Enabled = false;
            this.rbTaksit.Location = new System.Drawing.Point(39, 55);
            this.rbTaksit.Name = "rbTaksit";
            this.rbTaksit.Size = new System.Drawing.Size(54, 17);
            this.rbTaksit.TabIndex = 9;
            this.rbTaksit.TabStop = true;
            this.rbTaksit.Text = "Taksit";
            this.rbTaksit.UseVisualStyleBackColor = true;
            this.rbTaksit.CheckedChanged += new System.EventHandler(this.rbTaksit_CheckedChanged);
            // 
            // cmbTaksit
            // 
            this.cmbTaksit.Enabled = false;
            this.cmbTaksit.FormattingEnabled = true;
            this.cmbTaksit.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbTaksit.Location = new System.Drawing.Point(482, 307);
            this.cmbTaksit.Name = "cmbTaksit";
            this.cmbTaksit.Size = new System.Drawing.Size(121, 21);
            this.cmbTaksit.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(656, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstEklenen
            // 
            this.lstEklenen.FormattingEnabled = true;
            this.lstEklenen.Location = new System.Drawing.Point(28, 174);
            this.lstEklenen.Name = "lstEklenen";
            this.lstEklenen.Size = new System.Drawing.Size(120, 95);
            this.lstEklenen.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nakit:";
            // 
            // lblNakit
            // 
            this.lblNakit.AutoSize = true;
            this.lblNakit.Location = new System.Drawing.Point(316, 256);
            this.lblNakit.Name = "lblNakit";
            this.lblNakit.Size = new System.Drawing.Size(0, 13);
            this.lblNakit.TabIndex = 14;
            // 
            // lblTaksit
            // 
            this.lblTaksit.AutoSize = true;
            this.lblTaksit.Location = new System.Drawing.Point(316, 285);
            this.lblTaksit.Name = "lblTaksit";
            this.lblTaksit.Size = new System.Drawing.Size(0, 13);
            this.lblTaksit.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Taksit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKredi);
            this.groupBox1.Controls.Add(this.rbNakit);
            this.groupBox1.Location = new System.Drawing.Point(212, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödeme Tipi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbWord);
            this.groupBox2.Controls.Add(this.rbAccess);
            this.groupBox2.Controls.Add(this.rbBonus);
            this.groupBox2.Location = new System.Drawing.Point(212, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kart Tipi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbTek);
            this.groupBox3.Controls.Add(this.rbTaksit);
            this.groupBox3.Location = new System.Drawing.Point(212, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tek Çekim/Taksit";
            // 
            // frmKrediKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTaksit);
            this.Controls.Add(this.lblNakit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstEklenen);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbTaksit);
            this.Controls.Add(this.cmbKur);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.txtİsim);
            this.Name = "frmKrediKart";
            this.Text = "frmKrediKart";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.ComboBox cmbKur;
        private System.Windows.Forms.RadioButton rbKredi;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.RadioButton rbWord;
        private System.Windows.Forms.RadioButton rbAccess;
        private System.Windows.Forms.RadioButton rbBonus;
        private System.Windows.Forms.RadioButton rbTek;
        private System.Windows.Forms.RadioButton rbTaksit;
        private System.Windows.Forms.ComboBox cmbTaksit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstEklenen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNakit;
        private System.Windows.Forms.Label lblTaksit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}