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
    public partial class frmİsim : Form
    {
        public frmİsim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            //string sonuc="";

            for (int i = 1; i <= isim.Length; i++)
            {
                //sonuc += isim[i];
                // listBox1.Items.Add(sonuc);
                listBox1.Items.Add(isim.Substring(0, i));
                


            }
        }
    }
}
