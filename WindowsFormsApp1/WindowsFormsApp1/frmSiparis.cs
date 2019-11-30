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
    public partial class frmSiparis : Form
    {
        public frmSiparis()
        {
            InitializeComponent();
        }

        private void frmSiparis_Load(object sender, EventArgs e)
        {
            lstMeyve.Items.Add("elma");
            lstMeyve.Items.Add("armut");
            lstMeyve.Items.Add("ananas");
            lstFiyat.Items.Add("2");
            lstFiyat.Items.Add("3");
            lstFiyat.Items.Add("5");

        }

        private void btnArti_Click(object sender, EventArgs e)
        {
          lblfiyat.Text = (Convert.ToInt32(lblfiyat.Text)+1).ToString();
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            lblfiyat.Text = (Convert.ToInt32(lblfiyat.Text) - 1).ToString();
        }

        private void lstMeyve_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstFiyat.SelectedIndex = lstMeyve.SelectedIndex;
            

        }

        private void btnYeniSiparis_Click(object sender, EventArgs e)
        {
            lstSiparis.Items.Clear();
            lblHesap.Text = "0";
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            lblHesap.Text = (Convert.ToInt32(lblHesap.Text) + Convert.ToInt32(lstFiyat.SelectedItem) * Convert.ToInt32(lblfiyat.Text)).ToString();
            lstSiparis.Items.Add(lstMeyve.SelectedItem.ToString() + "-----------" + Convert.ToInt32(lstFiyat.SelectedItem)*Convert.ToInt32(lblfiyat.Text));
            lblfiyat.Text =" 0";
            lstMeyve.SelectedItem = null;
            lstFiyat.SelectedItem = null;
            //lstMeyve.SelectedIndex = -1; null gibidir.
            
        }
    }
}
