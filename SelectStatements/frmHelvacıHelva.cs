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
    public partial class frmHelvacıHelva : Form
    {
        public frmHelvacıHelva()
        {
            InitializeComponent();
        }
        int para = 20;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            string urunAdi = txtUrun.Text;
            int urunFiyat = Convert.ToInt32(txtFiyat.Text);
            int kilo = Convert.ToInt32(chkKilo.SelectedItem);
            int harcanan = (urunFiyat * kilo);
            para = para - (urunFiyat * kilo);

            if (para>-1)
            {
                lstAlısveris.Items.Add(urunAdi + "----" + harcanan + "-----" + para);
            }
            else
            {
                MessageBox.Show("Para yok");
            }

        }
    }
}
