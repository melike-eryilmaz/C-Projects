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
    public partial class frmMaas : Form
    {
        public frmMaas()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string isim = txtİsim.Text;
            float maas = Convert.ToSingle(txtMaas.Text);
            string kur = cmbKur.SelectedItem.ToString();
            string sonuc = isim + "-- " + maas + "-- " + kur;
            if (kur == "Dolar $")
            {
                maas = 6 * maas;
                lstMaas.Items.Add(sonuc);
                lblBrutt.Text = maas.ToString();
            }
            else if (kur == "Euro")
            {
                maas = 5 * maas;
                lstMaas.Items.Add(sonuc);
                lblBrutt.Text = maas.ToString();


            }
            else
            {
                maas = 5 * maas;

                lstMaas.Items.Add(sonuc);
                lblBrutt.Text = maas.ToString();


            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            float kira = Convert.ToSingle(txtKira.Text);
            float fatura = Convert.ToSingle(txtFatura.Text);
            float mutfak = Convert.ToSingle(txtFatura.Text);
            float maas = Convert.ToSingle(lblBrutt.Text);
            float kalanMaas =( maas - (fatura + kira + mutfak));
            string sonuc = txtİsim.Text + "-- " + kalanMaas ;

            if (kalanMaas<0)
            {
                lstBorclu.Items.Add(sonuc + "tl borclusunuz ");

            }
            else if (kalanMaas>0)
            {
                lstBorcsuz.Items.Add(sonuc + "tl paranız artmıştır");
            }
            else
            {
                MessageBox.Show("Kalan para 0 tl dir.Borcun yok :))");
            }
        }
    }
}
