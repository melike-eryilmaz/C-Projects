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
    public partial class ifExample4 : Form
    {
        public ifExample4()
        {
            InitializeComponent();
        }

        private void btnOrt_Click(object sender, EventArgs e)
        {
            float vize1 = Convert.ToSingle(txtVize.Text);
            float final1 = Convert.ToSingle(txtFinal.Text);
            float ortalama = vize1 * 0.4f+ final1 * 0.6f;
            string sonuc = textBox1.Text + " " + ortalama;
            if (ortalama>0&&ortalama<50)
            {
                lstKalanlar.Items.Add(sonuc+" fd");
            }
            else if(ortalama>=50&&ortalama<55)
            {
                lstSartlı.Items.Add(sonuc + " dd");
            }
            else if (ortalama>=55&&ortalama<60)
            {
                lstSartlı.Items.Add(sonuc + " dc");
            }
            else if (ortalama>=60&&ortalama<70)
            {
                lstGecenler.Items.Add(sonuc + " cc");
            }
            else if (ortalama >= 70 && ortalama<80)
            {
                lstGecenler.Items.Add(sonuc +  " cb");

            }
            else if (ortalama >= 80 && ortalama < 85)
            {
                lstGecenler.Items.Add(sonuc + " bb");

            }
            else if (ortalama >= 85 && ortalama < 90)
            {
                lstGecenler.Items.Add(sonuc + " ba");

            }
            else if (ortalama >= 90&& ortalama < 100)
            {
                lstGecenler.Items.Add(sonuc + " aa");

            }
            else
            {
                lstKalanlar.Items.Add(sonuc + " ff");
            }
        }
}
    }
