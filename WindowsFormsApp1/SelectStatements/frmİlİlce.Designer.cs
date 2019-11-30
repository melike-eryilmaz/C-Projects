namespace SelectStatements
{
    partial class frmİlİlce
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
            this.cmbİl = new System.Windows.Forms.ComboBox();
            this.cmbİlce = new System.Windows.Forms.ComboBox();
            this.txtSokak = new System.Windows.Forms.TextBox();
            this.txtApart = new System.Windows.Forms.TextBox();
            this.lstAdres = new System.Windows.Forms.ListBox();
            this.btnBin = new System.Windows.Forms.Button();
            this.lblİl = new System.Windows.Forms.Label();
            this.lblİlce = new System.Windows.Forms.Label();
            this.lblSokak = new System.Windows.Forms.Label();
            this.lblApartman = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbİl
            // 
            this.cmbİl.FormattingEnabled = true;
            this.cmbİl.Items.AddRange(new object[] {
            "Antalya",
            "İzmir",
            "İstanbul",
            "Zonguldak"});
            this.cmbİl.Location = new System.Drawing.Point(34, 58);
            this.cmbİl.Name = "cmbİl";
            this.cmbİl.Size = new System.Drawing.Size(121, 21);
            this.cmbİl.TabIndex = 0;
            this.cmbİl.SelectedIndexChanged += new System.EventHandler(this.cmbİl_SelectedIndexChanged);
            // 
            // cmbİlce
            // 
            this.cmbİlce.Enabled = false;
            this.cmbİlce.FormattingEnabled = true;
            this.cmbİlce.Location = new System.Drawing.Point(34, 116);
            this.cmbİlce.Name = "cmbİlce";
            this.cmbİlce.Size = new System.Drawing.Size(121, 21);
            this.cmbİlce.TabIndex = 1;
            this.cmbİlce.SelectedIndexChanged += new System.EventHandler(this.cmbİlce_SelectedIndexChanged);
            // 
            // txtSokak
            // 
            this.txtSokak.Enabled = false;
            this.txtSokak.Location = new System.Drawing.Point(34, 176);
            this.txtSokak.Name = "txtSokak";
            this.txtSokak.Size = new System.Drawing.Size(100, 20);
            this.txtSokak.TabIndex = 2;
            this.txtSokak.TextChanged += new System.EventHandler(this.txtSokak_TextChanged);
            // 
            // txtApart
            // 
            this.txtApart.Enabled = false;
            this.txtApart.Location = new System.Drawing.Point(34, 233);
            this.txtApart.Name = "txtApart";
            this.txtApart.Size = new System.Drawing.Size(100, 20);
            this.txtApart.TabIndex = 3;
            // 
            // lstAdres
            // 
            this.lstAdres.FormattingEnabled = true;
            this.lstAdres.Location = new System.Drawing.Point(288, 58);
            this.lstAdres.Name = "lstAdres";
            this.lstAdres.Size = new System.Drawing.Size(120, 95);
            this.lstAdres.TabIndex = 4;
            // 
            // btnBin
            // 
            this.btnBin.Location = new System.Drawing.Point(59, 281);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(75, 23);
            this.btnBin.TabIndex = 5;
            this.btnBin.Text = "Bin";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // lblİl
            // 
            this.lblİl.AutoSize = true;
            this.lblİl.Location = new System.Drawing.Point(34, 25);
            this.lblİl.Name = "lblİl";
            this.lblİl.Size = new System.Drawing.Size(23, 13);
            this.lblİl.TabIndex = 6;
            this.lblİl.Text = "İller";
            // 
            // lblİlce
            // 
            this.lblİlce.AutoSize = true;
            this.lblİlce.Location = new System.Drawing.Point(34, 97);
            this.lblİlce.Name = "lblİlce";
            this.lblİlce.Size = new System.Drawing.Size(34, 13);
            this.lblİlce.TabIndex = 7;
            this.lblİlce.Text = "ilçeler";
            // 
            // lblSokak
            // 
            this.lblSokak.AutoSize = true;
            this.lblSokak.Location = new System.Drawing.Point(34, 157);
            this.lblSokak.Name = "lblSokak";
            this.lblSokak.Size = new System.Drawing.Size(51, 13);
            this.lblSokak.TabIndex = 8;
            this.lblSokak.Text = "sokak no";
            // 
            // lblApartman
            // 
            this.lblApartman.AutoSize = true;
            this.lblApartman.Location = new System.Drawing.Point(33, 214);
            this.lblApartman.Name = "lblApartman";
            this.lblApartman.Size = new System.Drawing.Size(71, 13);
            this.lblApartman.TabIndex = 9;
            this.lblApartman.Text = "apartman ismi";
            // 
            // frmİlİlce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblApartman);
            this.Controls.Add(this.lblSokak);
            this.Controls.Add(this.lblİlce);
            this.Controls.Add(this.lblİl);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.lstAdres);
            this.Controls.Add(this.txtApart);
            this.Controls.Add(this.txtSokak);
            this.Controls.Add(this.cmbİlce);
            this.Controls.Add(this.cmbİl);
            this.Name = "frmİlİlce";
            this.Text = "frmİlİlce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbİl;
        private System.Windows.Forms.ComboBox cmbİlce;
        private System.Windows.Forms.TextBox txtSokak;
        private System.Windows.Forms.TextBox txtApart;
        private System.Windows.Forms.ListBox lstAdres;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.Label lblİl;
        private System.Windows.Forms.Label lblİlce;
        private System.Windows.Forms.Label lblSokak;
        private System.Windows.Forms.Label lblApartman;
    }
}