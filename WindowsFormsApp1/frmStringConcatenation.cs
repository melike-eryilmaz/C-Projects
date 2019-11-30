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
    public partial class frmStringConcatenation : Form
    {
        public frmStringConcatenation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmButton_Click(object sender, EventArgs e)
        {
            //string ad = "Melike";
            //string soyad = "ERYILMAZ";
            //string isim = ad+" "+soyad;
            //MessageBox.Show(isim);
            string ad = txtAd.Text;
            string soyad =txtSoyad.Text;
            // string isim = ad + " " + soyad;
            string isim = "Adınız :"+ txtAd.Text + "  \nSoyadınız :  "+ txtSoyad.Text;
            MessageBox.Show(isim);
        }
    }
}
