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
    public partial class frmAsal : Form
    {
        public frmAsal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            bool asalmı=true;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi%i==0)
                {
                    asalmı = false;
                    break;
                }
               
            }
            if (asalmı)
            {
                label1.Text = "asal sayı";
            }
            else
            {
                label1.Text = "asal sayı değil";
            }
        }

      
    }
}
