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
    public partial class frmİfExampleHomework : Form
    {
        public frmİfExampleHomework()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string isim = txtİsim.Text;
            float vize = Convert.ToSingle(txtVize.Text);
            float final = Convert.ToSingle(txtFinal.Text);
            float Gno = Convert.ToSingle(txtGno.Text);
            int devamsızlık = Convert.ToInt32(txtDevam.Text);
            float notOrt = vize * 0.4f + final * 0.6f;
            string sonuc = isim + "  Ortalama: " + notOrt;
            
            if (devamsızlık < 10)
            {


                if (notOrt > 0 && notOrt < 50)
                {
                    lstNotKalanlar.Items.Add(sonuc + "FD");
                    //txtBut.Enabled = true;
                    //label7.Enabled = true;
                    //lstButunlemedeGecenler.Enabled = true;
                    //float butOrt = vize * 0.4f + final * 0.6f;
                    //if (butOrt >= 50)
                    //{
                    //    lstButunlemedeGecenler.Items.Add(sonuc + "Bütünleme sonrası ort: " + butOrt);
                    //}

                }
                else if (notOrt >= 50 && notOrt < 55)
                {
                    if (Gno >= 2)
                    {
                        lstSartlıGecenler.Items.Add(sonuc + "DD");
                    }
                    else
                    {
                        lstSartlıKalanlar.Items.Add(sonuc + "DD");
                    }
                }
                else if (notOrt >= 55 && notOrt < 60)
                {
                    if (Gno >= 2)
                    {
                        lstSartlıGecenler.Items.Add(sonuc + "DC");
                    }
                    else
                    {
                        lstSartlıKalanlar.Items.Add(sonuc + "DC");
                    }
                }
                else if (notOrt >= 60 && notOrt < 70)
                {
                    lstGecenler.Items.Add(sonuc + "CC");
                }
                else if (notOrt >= 70 && notOrt < 80)
                {
                    lstGecenler.Items.Add(sonuc + "CB");

                }
                else if (notOrt >= 80 && notOrt < 85)
                {
                    lstGecenler.Items.Add(sonuc + "BB");

                }
                else if (notOrt >= 85 && notOrt < 90)
                {
                    lstGecenler.Items.Add(sonuc + "BA");

                }
                else if (notOrt >= 90 && notOrt < 100)
                {
                    lstGecenler.Items.Add(sonuc + "AA");

                }
            }
            else
            {
                lstDevamKalanlar.Items.Add(sonuc + "NA");
                MessageBox.Show("Devamdan kaldın çiçeğimm");
            }

        }

    }
}
