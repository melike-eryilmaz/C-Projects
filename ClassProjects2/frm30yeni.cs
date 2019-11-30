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
    public partial class frm30yeni : Form
    {
        public frm30yeni()
        {
            InitializeComponent();
        }
        ArrayList liste = new ArrayList();
        RandomExample yeni = new RandomExample();
        private void button1_Click(object sender, EventArgs e)
        {
            int baslangic = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            Random rnd = new Random();
            for (int i = baslangic; i < bitis; i++)
            {
                int yenisayi = rnd.Next(baslangic, bitis);
                if (liste.Count!=0)
                {
                    if (liste.Contains(yenisayi))
                    {
                        i--;
                    }
                    else
                    {
                        liste.Add(yenisayi);
                    }
                }
                else
                {
                    liste.Add(yenisayi);
                }
               
            }
            for (int i = 0; i < liste.Count; i++)
            {
                listBox1.Items.Add(liste[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list=yeni.Sirala(liste);
            for (int i = 0; i < liste.Count; i++)
            {
                listBox2.Items.Add(liste[i]);
            }
        }
    }
}
