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
    public partial class frmKarsilastir : Form
    {
        public frmKarsilastir()
        {
            InitializeComponent();
        }
        Karsilastirma karsilastirma = new Karsilastirma();
        private void btnKarsilastir_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            ArrayList list1 = new ArrayList();
            for (int i = Convert.ToInt32(txtList1Baslangic.Text); i <=Convert.ToInt32(txtList1Bitis.Text); i++)
            {
                list.Add(i);
            }
            for (int i = Convert.ToInt32(txtList2Baslangic.Text); i <= Convert.ToInt32(txtList2Bitis.Text); i++)
            {
                list1.Add(i);
            }
            lstAynı.Items.Add(karsilastirma.Karsilastir(list,list1));
            //MessageBox.Show(karsilastirma.Karsilastir(list,list1).ToString());

        }
    }
}
