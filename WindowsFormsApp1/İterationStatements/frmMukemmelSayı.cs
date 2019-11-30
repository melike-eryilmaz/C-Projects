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
    public partial class frmMukemmelSayı : Form
    {
        public frmMukemmelSayı()
        {
            InitializeComponent();
        }

        private void frmMukemmelSayı_Load(object sender, EventArgs e)
        {
            
            for (int i = 2; i < 10000; i++)
            {
                int toplam = 0;
                for (int k = 1; k < i; k++)
                {
                    if (i%k==0)
                    {
                        toplam= k+toplam;
                    }
                   
                }
                if (toplam == i)
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
