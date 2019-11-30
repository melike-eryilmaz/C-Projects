using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOriantedProjects
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SALON salon = new SALON();
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(salon.SalonOlustur(textBox1.Text, textBox2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = salon.KoltukSat(checkBox1.Checked);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = salon.Koltukİptal();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = salon.BosKoltukGoruntule();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = salon.Guncel();

        }
    }
}
