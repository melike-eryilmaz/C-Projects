﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCikarma : Form
    {
        public frmCikarma()
        {
            InitializeComponent();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Convert.ToInt32(txtBirinciSayi.Text) - Convert.ToInt32(txtİkinciSayi.Text)).ToString());

        }

        private void frmCikarma_Load(object sender, EventArgs e)
        {

        }
    }
}
