using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassProjects2
{
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
        }
        Matematik mat = new Matematik();
        private void button1_Click(object sender, EventArgs e)
        { 
            MessageBox.Show(mat.Topla(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
           MessageBox.Show(mat.Cikar(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mat.Carp(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            MessageBox.Show(mat.Bol(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            if (radioButton1.Checked)
            {
                MessageBox.Show(mat.KareAl(Convert.ToInt32(textBox1.Text)));

            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show(mat.KareAl(Convert.ToInt32(textBox2.Text)));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show(mat.KupAl(Convert.ToInt32(textBox1.Text)));

            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show(mat.KupAl(Convert.ToInt32(textBox2.Text)));
            }
        }

      
    }
}
