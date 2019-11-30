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
    public partial class frmSerhatornek3 : Form
    {
        public frmSerhatornek3()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (rbKadın.Checked&&rb2.Checked)
            {
                listBox1.Items.Add(txtAd.Text);
            }
            else if (rbKadın.Checked&&rb1.Checked)
            {
                listBox2.Items.Add(txtAd.Text);

            }
            else if (rbErkek.Checked&&rb2.Checked)
            {
                listBox3.Items.Add(txtAd.Text);

            }
            else if (rbErkek.Checked&&rb1.Checked)
            {
                listBox4.Items.Add(txtAd.Text);

            }
            if(rb1.Checked==false&&rb2.Checked==false)
            {
                MessageBox.Show("Gözlük durumu secimi yap");
            }
            if (rbErkek.Checked == false && rbKadın.Checked == false)
            {
                MessageBox.Show("Cinsiyet secimi yap");
            }
            if((rb1.Checked == false && rb2.Checked == false)&& (rbErkek.Checked == false && rbKadın.Checked == false))
            {
                MessageBox.Show("Cinsiyet ve gözlük durumu secimi yap");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            rbErkek.Checked = false;
            rbKadın.Checked = false;
            rb1.Checked = false;
            rb2.Checked = false;


        }
    }
}
