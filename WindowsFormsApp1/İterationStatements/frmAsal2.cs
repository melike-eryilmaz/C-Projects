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
    public partial class frmAsal2 : Form
    {
        public frmAsal2()
        {
            InitializeComponent();
        }

     

        

        private void button1_Click(object sender, EventArgs e)
        {
            int i;


            for (i = 3; i < 100; i++)
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
                }
            }

        }
    }
}
