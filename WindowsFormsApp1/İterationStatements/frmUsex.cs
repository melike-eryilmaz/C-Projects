using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İterationStatements
{
    public partial class frmUsex : Form
    {
        public frmUsex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc = 1;
            int sayi = Convert.ToInt32(textBox1.Text);
            int us = Convert.ToInt32(textBox2.Text);
            for (int i = 1; i <=us; i++)
            {
                sonuc *= sayi;
            }
            MessageBox.Show(Convert.ToString(sonuc));
        }
    }
}
