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
    public partial class frmSerhatornek4 : Form
    {
        public frmSerhatornek4()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1 = Convert.ToInt32(txtsayi1.Text);
                int sayi2 = Convert.ToInt32(txtSayi2.Text);
                int sonuc;

                if (rbtopla.Checked)
                {
                    sonuc = sayi1 + sayi2;
                    listBox1.Items.Add(sayi1 + " + " + sayi2 + " = " + sonuc);

                }
                else if (rbcikar.Checked)
                {
                    sonuc = sayi1 - sayi2;
                    listBox1.Items.Add(sayi1 + " - " + sayi2 + " = " + sonuc);

                }
                else if (rbcarp.Checked)
                {
                    sonuc = sayi1 * sayi2;

                    listBox1.Items.Add(sayi1 + " x " + sayi2 + " = " + sonuc);


                }
                else
                {
                    float sonuc1 = (float)sayi1 / (float)sayi2;
                    listBox1.Items.Add(sayi1 + " /" + sayi2 + " = " + sonuc1);


                }
                txtsayi1.Clear();
                txtSayi2.Clear();

            }
            catch (Exception)
            {

                MessageBox.Show("Test");
            }
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtsayi1.Clear();
            txtSayi2.Clear();
            rbBol.Checked = false;
            rbcarp.Checked = false;
            rbcikar.Checked = false;
            rbtopla.Checked = false;


        }
    }
}
