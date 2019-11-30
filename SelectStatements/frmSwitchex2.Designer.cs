namespace SelectStatements
{
    partial class frmSwitchex2
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
            this.rbİfElse = new System.Windows.Forms.RadioButton();
            this.rbSwitchCase = new System.Windows.Forms.RadioButton();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.cmbKur = new System.Windows.Forms.ComboBox();
            this.lstTutar = new System.Windows.Forms.ListBox();
            this.btnHesap = new System.Windows.Forms.Button();
            this.lstİsim = new System.Windows.Forms.ListBox();
            this.lstBirim = new System.Windows.Forms.ListBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rbİfElse
            // 
            this.rbİfElse.AutoSize = true;
            this.rbİfElse.Location = new System.Drawing.Point(135, 85);
            this.rbİfElse.Name = "rbİfElse";
            this.rbİfElse.Size = new System.Drawing.Size(85, 17);
            this.rbİfElse.TabIndex = 0;
            this.rbİfElse.TabStop = true;
            this.rbİfElse.Text = "radioButton1";
            this.rbİfElse.UseVisualStyleBackColor = true;
          //  this.rbİfElse.CheckedChanged += new System.EventHandler(this.rbİfElse_CheckedChanged);
            // 
            // rbSwitchCase
            // 
            this.rbSwitchCase.AutoSize = true;
            this.rbSwitchCase.Location = new System.Drawing.Point(135, 131);
            this.rbSwitchCase.Name = "rbSwitchCase";
            this.rbSwitchCase.Size = new System.Drawing.Size(85, 17);
            this.rbSwitchCase.TabIndex = 1;
            this.rbSwitchCase.TabStop = true;
            this.rbSwitchCase.Text = "radioButton2";
            this.rbSwitchCase.UseVisualStyleBackColor = true;
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(135, 179);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(100, 20);
            this.txtİsim.TabIndex = 2;
            // 
            // cmbKur
            // 
            this.cmbKur.FormattingEnabled = true;
            this.cmbKur.Items.AddRange(new object[] {
            "euro",
            "dolar",
            "sterlin"});
            this.cmbKur.Location = new System.Drawing.Point(135, 233);
            this.cmbKur.Name = "cmbKur";
            this.cmbKur.Size = new System.Drawing.Size(121, 21);
            this.cmbKur.TabIndex = 3;
            // 
            // lstTutar
            // 
            this.lstTutar.FormattingEnabled = true;
            this.lstTutar.Location = new System.Drawing.Point(483, 146);
            this.lstTutar.Name = "lstTutar";
            this.lstTutar.Size = new System.Drawing.Size(120, 95);
            this.lstTutar.TabIndex = 4;
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(160, 284);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(75, 23);
            this.btnHesap.TabIndex = 5;
            this.btnHesap.Text = "hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // lstİsim
            // 
            this.lstİsim.FormattingEnabled = true;
            this.lstİsim.Location = new System.Drawing.Point(341, 146);
            this.lstİsim.Name = "lstİsim";
            this.lstİsim.Size = new System.Drawing.Size(120, 95);
            this.lstİsim.TabIndex = 6;
            // 
            // lstBirim
            // 
            this.lstBirim.FormattingEnabled = true;
            this.lstBirim.Location = new System.Drawing.Point(642, 146);
            this.lstBirim.Name = "lstBirim";
            this.lstBirim.Size = new System.Drawing.Size(120, 95);
            this.lstBirim.TabIndex = 7;
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(135, 207);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(100, 20);
            this.txtPara.TabIndex = 8;
            // 
            // frmSwitchex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.lstBirim);
            this.Controls.Add(this.lstİsim);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.lstTutar);
            this.Controls.Add(this.cmbKur);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.rbSwitchCase);
            this.Controls.Add(this.rbİfElse);
            this.Name = "frmSwitchex2";
            this.Text = "frmSwitchex2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbİfElse;
        private System.Windows.Forms.RadioButton rbSwitchCase;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.ComboBox cmbKur;
        private System.Windows.Forms.ListBox lstTutar;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.ListBox lstİsim;
        private System.Windows.Forms.ListBox lstBirim;
        private System.Windows.Forms.TextBox txtPara;
    }
}