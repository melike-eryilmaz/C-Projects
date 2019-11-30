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
    public partial class frmGuncellemeİslemi : Form
    {
        public frmGuncellemeİslemi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstEklenen.Items.Add(txtEkle.Text);
            // txtEkle.Text = null;
            txtEkle.Clear();
        }

        private void lstEklenen_DoubleClick(object sender, EventArgs e)
        {
            txtGuncelle.Text = lstEklenen.SelectedItem.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int index = lstEklenen.SelectedIndex;
            string eskiVeri = lstEklenen.SelectedItem.ToString();
            lstEklenen.Items.RemoveAt(index);
            lstEklenen.Items.Insert(index, txtGuncelle.Text);
            lstGuncellenen.Items.Add(eskiVeri);


        }
    }
}
