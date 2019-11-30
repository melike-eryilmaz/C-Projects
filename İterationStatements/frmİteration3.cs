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
    public partial class frmİteration3 : Form
    {
        public frmİteration3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            int artis = Convert.ToInt32(textBox3.Text);
            for (int i = baslangic; i <= bitis; i=i+artis)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
