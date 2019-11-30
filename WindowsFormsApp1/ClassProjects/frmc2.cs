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

namespace ClassProjects
{
    public partial class frmc2 : Form
    {
        public frmc2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int satir = Convert.ToInt32(textBox1.Text);
            ////ArrayList liste = new ArrayList();
            //for (int i = 1; i <= satir; i++)
            //{
            //    string k1 = "";
            //    for (int k =0 ; k < i; k++)
            //    {
            //        k1 += i ;
                    
            //    }
            //        listBox1.Items.Add(k1);

            //}

        }

        private void frmc2_Load(object sender, EventArgs e)
        {
            int sonuc = 1;
            for (int i = 1; i <=10; i++)
            {
                int k;
                for ( k = 1; k <=10; k++)
                {
                    sonuc = i* k;
                    string met = i.ToString() + "X" + k.ToString() + "=" + sonuc.ToString();
                    listBox1.Items.Add(met);
                }

               

            }
        }
    }
}
