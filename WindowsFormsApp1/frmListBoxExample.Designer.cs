﻿namespace WindowsFormsApp1
{
    partial class frmListBoxExample
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
            this.txtİfade = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtİfade
            // 
            this.txtİfade.Location = new System.Drawing.Point(100, 55);
            this.txtİfade.Name = "txtİfade";
            this.txtİfade.Size = new System.Drawing.Size(100, 20);
            this.txtİfade.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(125, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.Location = new System.Drawing.Point(274, 55);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(120, 95);
            this.lstListe.TabIndex = 2;
            // 
            // frmListBoxExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtİfade);
            this.Name = "frmListBoxExample";
            this.Text = "frmListBoxExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtİfade;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstListe;
    }
}