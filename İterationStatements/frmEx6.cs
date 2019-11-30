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
    public partial class frmEx6 : Form
    {
        public frmEx6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            for (int i = baslangic; i <= bitis; i++)
            {
                if (i%2==-1 && i<0)
                {
                    listBox1.Items.Add(i);
                }
                else if (i>=0&&i%2==1)
                {
                    listBox2.Items.Add(i);
                 
                }
                else if (i < 0 && i % 2 == 0)
                {
                    listBox3.Items.Add(i);

                }
                else if (i >= 0 && i % 2 == 0)
                {
                    listBox4.Items.Add(i);

                }
            }
        }
    }
}
