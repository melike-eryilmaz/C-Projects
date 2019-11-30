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
    public partial class frmWork : Form
    {
        public frmWork()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                listBox1.Items.Add(textBox1.Text);
            }
            if (checkBox2.Checked)
            {
                listBox2.Items.Add(textBox1.Text);
            }
            if (checkBox3.Checked)
            {
                listBox3.Items.Add(textBox1.Text);
            }
            if (checkBox4.Checked)
            {
                listBox4.Items.Add(textBox1.Text);
            }
        }
        string[] dizi;
        private void button7_Click(object sender, EventArgs e)
        {
            int count = listBox2.Items.Count;
            dizi = new string[count];
            for (int i = 0; i < count; i++)
            {
                dizi[i] = listBox2.Items[i].ToString();
            }
            //foreach (var i in dizi)
            //{
            //    MessageBox.Show(i);

            //}
        }

        private void button2_Click(object sender, EventArgs e)

        {
            int count = dizi.Count();
            for (int i = 0; i < count; i++)
            {
                listBox3.Items.Add(dizi[i]);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int count = listBox3.Items.Count;
            dizi = new string[count];
            for (int i = 0; i < count; i++)
            {
                dizi[i] = listBox3.Items[i].ToString();

            }
            //foreach (var i in dizi)
            //{
            //    MessageBox.Show(i);

            //}
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int count = dizi.Count();
            for (int i = 0; i < count; i++)
            {
                listBox4.Items.Add(dizi[i]);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int count = listBox4.Items.Count;
            dizi = new string[count];
            for (int i = 0; i < count; i++)
            {
                dizi[i] = listBox4.Items[i].ToString();

            }
            //foreach (var i in dizi)
            //{
            //    MessageBox.Show(i);

            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = dizi.Count();
            for (int i = 0; i < count; i++)
            {
                listBox1.Items.Add(dizi[i]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int count = listBox1.Items.Count;
            dizi = new string[count];
            for (int i = 0; i < count; i++)
            {
                dizi[i] = listBox1.Items[i].ToString();

            }
            //foreach (var i in dizi)
            //{
            //    MessageBox.Show(i);

            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = dizi.Count();
            for (int i = 0; i < count; i++)
            {
                listBox2.Items.Add(dizi[i]);
            }
        }
    }  
}
