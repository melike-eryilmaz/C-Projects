using System;
using System.Collections;
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
    public partial class frmAsal3 : Form
    {
        public frmAsal3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int toplam=0,toplam1=0;
            ArrayList asal = new ArrayList();
            ArrayList asalnot = new ArrayList();

            for (int i = 3; i < 100; i++)
            {
                bool asalmı = true;
                for (int k = 2; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        asalmı = false;
                        break;
                    }

                }
                if (asalmı)
                {
                    listBox1.Items.Add(i);
                    asal.Add(i);
                }
                else
                {
                    listBox2.Items.Add(i);
                    asalnot.Add(i);
                }
            }
            for (int i = 0; i < asal.Count; i++)
            {
                toplam = toplam + Convert.ToInt32(asal[i]);

            }
            for (int i = 0; i < asalnot.Count; i++)
            {
                toplam1 = toplam1 + Convert.ToInt32(asalnot[i]);

            }
            label1.Text = toplam.ToString();
            label2.Text = toplam1.ToString();

            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    toplam =Convert.ToInt32( listBox1.Items[i])+toplam;
            //}
            //for (int i = 0; i < listBox2.Items.Count; i++)
            //{
            //    toplam1 = Convert.ToInt32(listBox2.Items[i]) + toplam1;
            //}
            //label1.Text = toplam.ToString();
            //label2.Text = toplam1.ToString();
        }
    }
}
