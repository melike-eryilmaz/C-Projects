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
    public partial class ifExample3 : Form
    {
        public ifExample3()
        {
            InitializeComponent();
        }

        private void btnOrt_Click(object sender, EventArgs e)
        {
            int vize = Convert.ToInt32(txtVize.Text);
            int final = Convert.ToInt32(txtFinal.Text);
            double ortalama = (double)vize * 0.4 +(double) final * 0.6;
            if (ortalama>50)
            {
                lstGecenler.Items.Add(txtAd.Text + "   ortalama:  " + ortalama + "  vize: " + txtVize.Text + " final " + txtFinal.Text);
            }
            else
            {
                lstKalanlar.Items.Add(txtAd.Text + "   ortalama:  " + ortalama + "  vize: " + txtVize.Text + " final " + txtFinal.Text);
            }
        }
    }
}
