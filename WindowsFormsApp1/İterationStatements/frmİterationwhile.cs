using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İterationStatements
{
    public partial class frmİterationwhile : Form
    {
        public frmİterationwhile()
        {
            InitializeComponent();
        }

        private void frmİterationwhile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double time, time1, time2;
            Stopwatch timer1 = new Stopwatch();

            int baslangic = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            timer1.Start();
            for (int i = baslangic; i < bitis; i++)
            {
                listBox1.Items.Add(i);
            }
            timer1.Stop();
            time = timer1.Elapsed.TotalMilliseconds;
            label1.Text = timer1.Elapsed.ToString();
            timer1.Reset();

            int j = baslangic;
            timer1.Start();
            while (j < bitis)
            {
                listBox2.Items.Add(j);
                j++;
            }
            timer1.Stop();
            time1 = timer1.Elapsed.TotalMilliseconds;

            label2.Text = timer1.Elapsed.ToString();
            timer1.Reset();
            int v = baslangic;
            timer1.Start();

            do
            {
                listBox3.Items.Add(v);
                v++;

            } while (v < bitis);
            timer1.Stop();
            time2 = timer1.Elapsed.TotalMilliseconds;
            //time2 = timer1.Elapsed.TotalMilliseconds;
            //timer1.Restart();

            label3.Text = timer1.Elapsed.ToString();
            double[] dizi = { time, time1, time2 };
            string[] dongudizi = { "forsure", "whilesure", "dowhilesure" };
            string gecici1;
            double enkucuk, gecici;
            for (int i = 0; i <dizi.Length; i++)
            {
                for (int k= i; k <dizi.Length; k++)
                {
                    if (dizi[i]>dizi[k])
                    {

                        gecici = dizi[i];
                        dizi[i] = dizi[k];
                        dizi[k] = gecici;
                        gecici1 = dongudizi[i];
                        dongudizi[i] = dongudizi[k];
                        dongudizi[k] = gecici1;

                    }
                }
                
            }

            MessageBox.Show("Küçükten büyüğe : "+dongudizi[0] + dizi[0]+"<"+dongudizi[1]+dizi[1]+"<"+dongudizi[2]+dizi[2]);
            //if (time<time1&&time<time2)
            //{
            //    MessageBox.Show("for daha hızlı");
            //}
            //else if(time1<time&&time1<time2)
            //{
            //    MessageBox.Show("while daha hızlı");

            //}
            //else
            //{
            //    MessageBox.Show("do while daha hızlı");

            //}
        }
    }
}
