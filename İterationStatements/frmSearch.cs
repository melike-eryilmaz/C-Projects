using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İterationStatements
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstEklenen.Items.Add(txtEklenen.Text);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtAranan.Text;
            for (int i = 0; i < lstEklenen.Items.Count; i++)
            {
                if (lstEklenen.Items[i].ToString().Equals(aranan))
                {
                    lstBulunan.Items.Add(lstEklenen.Items[i]);
                    lstEklenen.Items.RemoveAt(i);
                   
                    break;
                    

                }

                if (lstEklenen.Items[i].ToString().Contains(aranan))
                {
                    lstİceren.Items.Add(aranan);
                    break;


                }
                else
                {
                    lstBulunmayan.Items.Add(aranan);break;
                }

                //label1.Text = lstEklenen.Items.Count.ToString();
                //label2.Text = lstBulunan.Items.Count.ToString();
                //label3.Text = lstBulunmayan.Items.Count.ToString();
                //label5.Text =lstİceren.Items.Count.ToString();


            }

        }
    }
}
