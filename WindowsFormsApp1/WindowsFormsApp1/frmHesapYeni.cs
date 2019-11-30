using System;
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
    public partial class frmHesapYeni : Form
    {
        public frmHesapYeni()
        {
            InitializeComponent();
        }

       

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text= textBox1.Text+btn8.Text;

        }

        private void btnc_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn7.Text;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn9.Text;

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn4.Text;

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn5.Text;

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn6.Text;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn1.Text;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn2.Text;

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + btn3.Text;

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            //textBox1.Clear();
            //int index = textBox1.Text.Length;
            //string kelime = textBox1.Text;
            //textBox1.Text=kelime.Remove(index-1);

            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);

        }
    }
}
