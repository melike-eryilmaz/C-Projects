using System;
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
    public partial class frmStringmetot : Form
    {
        public frmStringmetot()
        {
            InitializeComponent();
        }

        private void frmStringmetot_Load(object sender, EventArgs e)
        {
            string ifade;
            string[] dizi = new string[3];
            //if (dizi.Any())
            //{

            //}
            //if (ifade.Contains("ab"))
            //{

            //}
            //if (ifade.Equals("mlk"))
            //{

            //}
            //int count = ifade.Count();
            //int longcount = dizi.LongCount();
            //if (ifade.StartsWith("mwwww"))
            //{

            //}
            //if ((ifade.EndsWith(".com")||ifade.EndsWith(".net"))
            //{

            //}
            //ifade = "ibrahim";
            //MessageBox.Show(ifade.Replace("i","ö"));
            //MessageBox.Show(ifade.ToLower());
            //MessageBox.Show(ifade.ToUpper());
            //ifade.Trim();//aradaki boşluklar da karakter olduğu için kaldırmaz.
            //ifade.TrimEnd();
            //ifade.TrimStart();
            //MessageBox.Show(ifade.Remove(3));
            //MessageBox.Show(ifade.Remove(3,2));//aradan siler
            //MessageBox.Show(ifade.Substring(3,2));//stringi kesip verir
            //ifade.Split('-');



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi = textBox1.Text.Split('-');
            foreach (var item in dizi)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
