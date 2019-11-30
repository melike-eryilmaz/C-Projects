using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassProjects2
{
    public partial class frmİslemler : Form
    {
        public frmİslemler()
        {
            InitializeComponent();
        }

        private void frmİslemler_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtSayi.Text);
            lstEklenen.Items.Add(sayi);
        }
        
        private void btnİslem_Click(object sender, EventArgs e)
        {
            İslemler yeni = new İslemler();
            ArrayList list = new ArrayList();
            ArrayList list2 = new ArrayList() {chkTopla.Checked,chkCikar.Checked,chkCarp.Checked,chkBol.Checked};
            for (int i = 0; i < lstEklenen.Items.Count; i++)
            {
                list.Add(lstEklenen.Items[i]);
            }
            MessageBox.Show(yeni.İslemYap(list,list2).ToString());
        }
    }
}
