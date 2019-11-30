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
    public partial class frmHesapMakinesi : Form
    {
       
        
        public frmHesapMakinesi()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            
            try
            {
                double sayi1, sayi2, sonuc;

                sayi1 = Convert.ToDouble(txtBirinciSayi.Text);
                sayi2 = Convert.ToDouble(txtİkinciSayi.Text);
                sonuc = sayi1 + sayi2;
                lblDe.Text = Convert.ToString(sonuc);
            }
            catch (Exception)
            {

                MessageBox.Show("LÜTFEN DÜZGÜNN İFADE GİR");
            }
            


        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(txtBirinciSayi.Text);
            sayi2 = Convert.ToDouble(txtİkinciSayi.Text);
            sonuc = sayi1 - sayi2;
            lblDe.Text = Convert.ToString(sonuc);
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(txtBirinciSayi.Text);
            sayi2 = Convert.ToDouble(txtİkinciSayi.Text);
            sonuc = sayi1 / sayi2;
            lblDe.Text = Convert.ToString(sonuc);
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(txtBirinciSayi.Text);
            sayi2 = Convert.ToDouble(txtİkinciSayi.Text);
            sonuc = sayi1 * sayi2;
            lblDe.Text = Convert.ToString(sonuc);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        
    }
}
