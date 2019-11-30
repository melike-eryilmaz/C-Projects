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
    public partial class itSt1 : Form
    {
        public itSt1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < lst1.Items.Count; i++)
            {
                lst2.Items.Add(lst1.Items[i]);

            }
            for (int i = lst1.Items.Count-1; i >=0; i--)
            {
                
                lst1.Items.RemoveAt(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lst1.Items.Add(txt1.Text);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
                else
                {
                    listBox2.Items.Add(i);

                }

            }
        }
    }
}
