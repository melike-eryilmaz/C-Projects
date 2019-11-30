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
    public partial class frmSerhatHesapmak : Form
    {
        public frmSerhatHesapmak()
        {
            InitializeComponent();
        }
        string operation;
        int sonuc;
        int sayi1;
        int sayi2;
        private void btne_Click(object sender, EventArgs e)
        {
            int sayi2 = Convert.ToInt32(txtSayi.Text);
            switch (operation)
            {
                case "+":
                    sonuc = sayi2 + sayi1;
                    txtSayi.Text = sonuc.ToString();
                    break;
                case "-":
                    sonuc = sayi2 - sayi1;
                    txtSayi.Text = sonuc.ToString();


                    break;
                case "*":
                    sonuc = sayi2 *sayi1;
                    txtSayi.Text = sonuc.ToString();


                    break;
                case "/":
                    sonuc = sayi2 / sayi1;
                    txtSayi.Text = sonuc.ToString();


                    break;
                default:
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSayi.Text = txtSayi.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSayi.Text = txtSayi.Text + button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSayi.Text = txtSayi.Text + button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSayi.Text = txtSayi.Text + button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtSayi.Text = txtSayi.Text + button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtSayi.Text = txtSayi.Text + button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtSayi.Text = txtSayi.Text + button7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtSayi.Text = txtSayi.Text + button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtSayi.Text = txtSayi.Text + button9.Text;

        }

        private void btnto_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi.Text);
            txtSayi.Text = null;
            operation= "+";
        }

        private void btnci_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi.Text);
            txtSayi.Text = null;
            operation = "-";
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi.Text);
            txtSayi.Text = null;
            operation = "*";
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi.Text);
            txtSayi.Text = null;
            operation = "/";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtSayi.Text = txtSayi.Text + btn0.Text;
            txtSayi.Text = null;

        }

        private void btnc_Click(object sender, EventArgs e)
        {
            int indis = txtSayi.Text.Length;
        }

        private void btnac_Click(object sender, EventArgs e)
        {
            sayi1 = 0;
            sayi2 = 0;
            txtSayi.Clear();

        }
    }
}
