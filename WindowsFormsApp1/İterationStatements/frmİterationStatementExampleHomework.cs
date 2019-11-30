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
    public partial class frmİterationStatementExampleHomework : Form
    {
        public frmİterationStatementExampleHomework()
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count!=0)
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                }
                for (int i =listBox1.Items.Count-1; i >=0; i--)
                {
                    listBox1.Items.RemoveAt(i);
                }
            }
            else
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox1.Items.Add(listBox2.Items[i]);
                }
                for (int i = listBox2.Items.Count - 1; i >= 0; i--)
                {
                    listBox2.Items.RemoveAt(i);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count != 0)
            {
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox3.Items.Add(listBox2.Items[i]);
                }
                for (int i = listBox2.Items.Count - 1; i >= 0; i--)
                {
                    listBox2.Items.RemoveAt(i);
                }
            }
            else
            {
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    listBox2.Items.Add(listBox3.Items[i]);
                }
                for (int i = listBox3.Items.Count - 1; i >= 0; i--)
                {
                    listBox3.Items.RemoveAt(i);
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox3.Items.Count != 0)
            {
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    listBox4.Items.Add(listBox3.Items[i]);
                }
                for (int i = listBox3.Items.Count - 1; i >= 0; i--)
                {
                    listBox3.Items.RemoveAt(i);
                }
            }
            else
            {
                for (int i = 0; i < listBox4.Items.Count; i++)
                {
                    listBox3.Items.Add(listBox4.Items[i]);
                }
                for (int i = listBox4.Items.Count - 1; i >= 0; i--)
                {
                    listBox4.Items.RemoveAt(i);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox4.Items.Count != 0)
            {
                for (int i = 0; i < listBox4.Items.Count; i++)
                {
                    listBox1.Items.Add(listBox4.Items[i]);
                }
                for (int i = listBox4.Items.Count - 1; i >= 0; i--)
                {
                    listBox4.Items.RemoveAt(i);
                }
            }
            else
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox4.Items.Add(listBox1.Items[i]);
                }
                for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.RemoveAt(i);
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
