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
    public partial class frmEskenar : Form
    {
        public frmEskenar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= sayi; i++)
            {
                string sonuc = "";
                for (int k = sayi-i; k >0 ; k--)
                {
                    sonuc += " ";

                   
                }
                for (int j = 0; j < i; j++)
                {
                    sonuc += "* ";
                }

                listBox1.Items.Add(sonuc);
            }
        }
    }
}
