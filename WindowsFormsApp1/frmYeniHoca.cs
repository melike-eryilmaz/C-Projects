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
    public partial class frmYeniHoca : Form
    {
        public frmYeniHoca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstListem.Items.Add("adı:"+txtAd.Text + "  sıyadı: " + txtEkle.Text);
            txtAd.Clear();
            txtEkle.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                lstListem.Items.RemoveAt(lstListem.SelectedIndex);
            }
            catch (Exception)
            {

                MessageBox.Show("secim yapsana ");
            } 
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            lstListem.Items.Clear();
        }
    }
}
