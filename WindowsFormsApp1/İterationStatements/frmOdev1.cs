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
    public partial class frmOdev1 : Form
    {
        public frmOdev1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstChange.Items.Add(txtEklenen.Text);
        }
        int sayac = 0;
        int tık = 0;
        string[] dizi1;
        string[] dizi;

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            tık++;
            sayac++;
            lblDegisim.Text = sayac.ToString();
            int boyut = lstChange.Items.Count;
            if (tık == 1)
            {
                dizi = new string[boyut];

                for (int i = 0; i < boyut; i++)
                {

                    dizi[i] = lstChange.Items[i].ToString();
                }
            }
             dizi1= new string[boyut];
            lstChange.Items.Insert(0, lstChange.Items[lstChange.Items.Count - 1]);
            lstChange.Items.RemoveAt(lstChange.Items.Count - 1);
            for (int i = 0; i < boyut; i++)
            {

                dizi1[i] = lstChange.Items[i].ToString();
            }
            if (dizi[0].ToString() == dizi1[0].ToString())
            {
                chkSame.Checked = true;
            }
            else
            {
                chkSame.Checked = false;
            }


        }
           



            //foreach (var i in dizi)
            //{
            //    MessageBox.Show(i);
            //}
            //lstChange.Items.Insert(0,dizi[boyut-1]);
            //lstChange.Items.RemoveAt(boyut - 1);
            //string[] yenidizi = new string[boyut];

            //for (int i = 0; i < boyut; i++)
            //{

            //    //if (i == 0)
            //    //{
            //    //    yenidizi[i] = dizi[boyut - 1];
            //    //    lstChange.Items[i] = yenidizi[i];

            //    //}
            //    //else
            //    //{
            //    //    yenidizi[i] = dizi[i - 1];
            //    //    lstChange.Items[i] = yenidizi[i];

            //    //}


            //}
            //if (dizi[0] == yenidizi[0])
            //{
            //    chkSame.Checked = true;
            //}
            //else
            //{
            //    chkSame.Checked = false;
            //}


        }
    }

