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
    public partial class frmYeni2 : Form
    {
        public frmYeni2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi%2==0)
            {
                listBox1.Items.Add(sayi);
               
                label1.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(label1.Text)).ToString();


            }
            else
            {
                listBox2.Items.Add(sayi);
                label2.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(label2.Text)).ToString();


            }

        }
    }
}
