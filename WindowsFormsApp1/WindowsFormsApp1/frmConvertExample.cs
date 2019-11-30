using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmConvertExample : Form
    {
        public frmConvertExample()
        {
            InitializeComponent();
        }

        private void frmAddButton_Click(object sender, EventArgs e)
        {

            //int sayi1 = Convert.ToInt32(txtSayi1.Text);
            //int  sayi2 = Convert.ToInt32(txtSayi2.Text);
            //int sonuc = sayi1 + sayi2;
            //MessageBox.Show(sonuc.ToString());
            MessageBox.Show((Convert.ToInt32(txtSayi1.Text) + Convert.ToInt32(txtSayi2.Text)).ToString());
        }
    }
}
