using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectStatements
{
    public partial class frmSerhatSwitchornek1 : Form
    {
        public frmSerhatSwitchornek1()
        {
            InitializeComponent();
        }

        private void btnSorgu_Click(object sender, EventArgs e)
        {
            //ctrl+k+d reformat code
            //    int sayi = Convert.ToInt32(txtSayi.Text);
            //    if (sayi%2==0)
            //    {
            //        lstCift.Items.Add(sayi);

            //    }
            //    else
            //    {
            //        lstTek.Items.Add(sayi);
            //    }
            int sayi = Convert.ToInt32(txtSayi.Text);
            int kalan = sayi % 2;
            switch (kalan)
            {
                case 1:
                    lstTek.Items.Add(sayi); break;
                case 0:
                    lstCift.Items.Add(sayi); break;

                default:
                    break;
            }
            txtSayi.Clear();

        }
    }
}
