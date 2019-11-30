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
    public partial class frmTekCift : Form
    {
        public frmTekCift()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
           
            try
            {
                int sayi = Convert.ToInt32(txtSayi.Text);

                if (sayi % 2 == 0)
                {
                    cmbTek.Items.Add(sayi);
                    txtSayi.Clear();
                }
                else
                {
                    lstCift.Items.Add(sayi);
                    txtSayi.Clear();


                }
            }
            catch (Exception)
            {

                MessageBox.Show("yanlış deger");
            }
        }
    }
}
