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
    public partial class frmYeni : Form
    {
        public frmYeni()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            label1.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(label1.Text)).ToString();
           
            //int sayi = Convert.ToInt32(textBox1.Text);
            //listBox1.Items.Add(sayi);
            //int[] dizi = new int[listBox1.Items.Count];
            //int toplam = 0;
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    dizi[i] = Convert.ToInt32(listBox1.Items[i]);
            //    toplam += dizi[i];
            //}
            //label1.Text = toplam.ToString();
        }
    }
}
