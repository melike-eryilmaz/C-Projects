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
    public partial class frmİteration5 : Form
    {
        public frmİteration5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ifade = textBox1.Text;
            for (int i = 0; i < ifade.Length; i++)
            {
                listBox1.Items.Add(ifade[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ifade = textBox1.Text;
            for (int i = ifade.Length-1; i>=0; i--)
            {
                listBox2.Items.Add(ifade[i]);
            }
            textBox1.Clear();
        }
    }
}
