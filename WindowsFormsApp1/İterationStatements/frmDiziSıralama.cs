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

namespace İterationStatements
{
    public partial class frmDiziSıralama : Form
    {
        public frmDiziSıralama()
        {
            InitializeComponent();
        }
        int tık=0;
        ArrayList liste = new ArrayList();
        int gecici;


        private void button1_Click(object sender, EventArgs e)
        {
             tık++;
            int sayi = Convert.ToInt32(textBox1.Text);
            liste.Add(sayi);
            listBox1.Items.Add(sayi);
            if (tık == 9)
            {
                button1.Enabled = false;

            }


       




            //MessageBox.Show("Küçükten büyüğe : "  + dizim[0] + "<" + dizim[1] + "<"  + dizim[2]);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < liste.Count / 2 - 1; i++)
            {
                for (int k = i; k < liste.Count /2; k++)
                {
                    if (Convert.ToInt32(liste[i]) > Convert.ToInt32(liste[k]))
                    {
                        gecici = Convert.ToInt32(liste[i]);
                        liste[i] = liste[k];
                        liste[k] = gecici;
                    }
                }
            }
            for (int i = liste.Count/2; i < liste.Count - 1; i++)
            {
                for (int k = i; k < liste.Count ; k++)
                {
                    if (Convert.ToInt32(liste[i]) > Convert.ToInt32(liste[k]))
                    {
                        gecici = Convert.ToInt32(liste[i]);
                        liste[i] = liste[k];
                        liste[k] = gecici;
                    }
                }
            }
        }
    }
}
