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
    public partial class frmİsaret : Form
    {
        public frmİsaret()
        {
            InitializeComponent();
        }

        private void btnİsaret_Click(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(txtSayi.Text)>0)
            //{
            //    MessageBox.Show("sayı pozitif");
            //}
            //else if(Convert.ToInt32(txtSayi.Text) < 0)
            //{
            //    MessageBox.Show("sayı negatif");
            //}
            //else
            //{
            //    MessageBox.Show("sayı sıfır");
            //}
            int sayi = Convert.ToInt32(txtSayi.Text);
            if (sayi>0&& sayi<100)
            {
                MessageBox.Show("sayı 0-100 aralığındadır");
            }
            else
            {
                MessageBox.Show("aralık dışı sayı");
            }
        }
    }
}
