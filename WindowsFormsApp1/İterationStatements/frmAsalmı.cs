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
    public partial class frmAsalmı : Form
    {
        public frmAsalmı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            //for (int i = 0; i < sayi; i++)
            //{
            //    string metin = "";
            //    for (int j =0;j<=i ; j++)
            //    {
            //        metin = metin+"*";
            //    }
            //    listBox1.Items.Add(metin);


            //}
            for (int i = 0; i < sayi; i++)
            {
                string metin = "";
                for (int j = sayi; j > i; j--)
                {
                    metin = metin + "*";
                }
                listBox1.Items.Add(metin);


            }
        }
    }
}
