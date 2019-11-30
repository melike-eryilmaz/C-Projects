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
    public partial class frmStringmethod : Form
    {
        public frmStringmethod()
        {
            InitializeComponent();
        }
        // double sonuc;

        private void button1_Click(object sender, EventArgs e)
        {
            Operation op = new Operation();
            MessageBox.Show(op.İslemYap(textBox1.Text));
            //string ifade = textBox1.Text;
            //if (ifade.Contains('+'))
            //{
            //    string[] dizi=ifade.Split('+');

            //    sonuc = Convert.ToInt32(dizi[0])+ Convert.ToInt32(dizi[1]);

            //}
            //if (ifade.Contains('-'))
            //{
            //    string[] dizi = ifade.Split('-');

            //    sonuc = Convert.ToInt32(dizi[0]) -Convert.ToInt32(dizi[1]);
            //}
            //if (ifade.Contains('/'))
            //{
            //    string[] dizi = ifade.Split('/');

            //    sonuc= Convert.ToSingle(dizi[0]) / Convert.ToSingle(dizi[1]);
            //}
            //if (ifade.Contains('*'))
            //{
            //    string[] dizi = ifade.Split('*');

            //    sonuc = Convert.ToInt32(dizi[0]) * Convert.ToInt32(dizi[1]);
            //}
            //MessageBox.Show(sonuc.ToString());
        }
    }
}
