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
    public partial class frmBirazdaoyun : Form
    {
        public frmBirazdaoyun()
        {
            InitializeComponent();
        }
        int sayi;
        int hak = 5;
        private void btnYenioyun_Click(object sender, EventArgs e)
        {
            txtSayi.Enabled = true;
            btnEsitmi.Enabled = true;
            Random rastgele = new Random();
            int sayi = rastgele.Next(0, 100);
          
        }

        private void btnEsitmi_Click(object sender, EventArgs e)
        {

            int girilen = Convert.ToInt32(txtSayi.Text);
           // MessageBox.Show("sayı"+sayi);


            if (sayi < girilen)
            {
                MessageBox.Show("Daha büyük bir sayı gir");
                hak--;
                listBox1.Items.Add(girilen);
            }
            else if (sayi > girilen)
            {
                MessageBox.Show("Daha lüçük bir sayı gir");
                hak--;
                listBox1.Items.Add(girilen);

            }
            else if (sayi == girilen)
            {
                MessageBox.Show("Tebrikler buldun");
            }
            else
            {
                MessageBox.Show("Sayi gir");
            }
            if (hak==0)
            {
                MessageBox.Show("Yeni oyuna geçiniz");
            }
        }
    }
}
