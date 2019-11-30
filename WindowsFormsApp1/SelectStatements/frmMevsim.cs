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
    public partial class frmMevsim : Form
    {
        public frmMevsim()
        {
            InitializeComponent();
        }

        private void btnMevsim_Click(object sender, EventArgs e)
        {
           int sayi = Convert.ToInt32(txtSayi.Text);
            switch (sayi)
            {
                case 1:
                case 2:
                case 3:
                    switch (sayi)
                    {
                        case 1:
                            MessageBox.Show("ocak"); break;

                        case 2:
                            MessageBox.Show("şubat "); break;

                        case 3:
                            MessageBox.Show("mart");break;



                    }
                    MessageBox.Show("kış");
                    break;
                    //case 1:
                    //    MessageBox.Show("mevsim kış ay ocak"); break;

                    //case 2:
                    //    MessageBox.Show("mevsim kış ay şubat"); break;

                    //case 12:
                    //    MessageBox.Show("mevsim kış ay aralık"); break;

                    //case 4:
                    //    MessageBox.Show("mevsim kış ay nisan"); break;

                    //case 3:
                    //    MessageBox.Show("mevsim kış ay mart"); break;

                    //case 5:
                    //    MessageBox.Show("mevsim kış ay mayıs"); break;


                    //case 6:
                    //    MessageBox.Show("mevsim kış ay haziran"); break;

                    //case 7:
                    //    MessageBox.Show("mevsim kış ay temmuz"); break;

                    //case 8:
                    //    MessageBox.Show("mevsim kış ay ağustos"); break;

                    //case 9:
                    //    MessageBox.Show("mevsim kış ay eylül"); break;

                    //case 10:
                    //    MessageBox.Show("mevsim kış ay ekim"); break;

                    //case 11:
                    //    MessageBox.Show("mevsim kış ay kasım"); break;
                    //default:
                    //    MessageBox.Show("1-12 aralıgında gir");
                    //    break;
            }

        }
    }
}
