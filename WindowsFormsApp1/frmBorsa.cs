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
    public partial class frmBorsa : Form
    {
        public frmBorsa()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstPara.Items.Add(txtPara.Text);
            lstKur.Items.Add(txtKur.Text);
            txtPara.Clear();
            txtKur.Clear();
        }

        private void lstPara_DoubleClick(object sender, EventArgs e)
        {
            //SelectedItem=txtPara.Text;
            //stKur.SelectedItem=txtKur.Text;
            int index = lstPara.SelectedIndex;
            txtPara.Text = lstPara.SelectedItem.ToString();
            lstKur.SelectedIndex = index;
            txtKur.Text = lstKur.SelectedItem.ToString();
           
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int index = lstPara.SelectedIndex;
            lstPara.Items.RemoveAt(index);
            lstPara.Items.Insert(index, txtPara.Text);

        }
    }
}
