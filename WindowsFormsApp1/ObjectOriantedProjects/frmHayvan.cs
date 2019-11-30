using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOriantedProjects
{
    public partial class frmHayvan : Form
    {
        public frmHayvan()
        {
            InitializeComponent();
        }
      
        Dog dog = new Dog();
        Sahip sahip = new Sahip();
        private void button6_Click(object sender, EventArgs e)
        {            
            textBox1.Visible = false;
            button6.Visible = false;
            label7.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;

            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;

            label4.Text = textBox1.Text;
            label5.Text = (dog.Mide).ToString();
            label6.Text = dog.mutluluk.ToString();
            label10.Text = sahip.sure.ToString();
            label12.Text = sahip.maliyet.ToString();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sahip.Sorgula(sahip.sure, sahip.maliyet, dog.Mide, dog.mutluluk));

            dog.MamaVer();
            label5.Text = (dog.Mide).ToString();
            sahip.MSAzalt(1, 1);
            label10.Text = sahip.sure.ToString();
            label12.Text = sahip.maliyet.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sahip.Sorgula(sahip.sure, sahip.maliyet, dog.Mide, dog.mutluluk));
            dog.Gezdir();
            label6.Text = dog.mutluluk.ToString();
            sahip.MSAzalt(0,2);
            label10.Text = sahip.sure.ToString();
            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sahip.Sorgula(sahip.sure, sahip.maliyet, dog.Mide, dog.mutluluk)); 
            dog.EtVer();
            label5.Text = (dog.Mide).ToString();
            sahip.MSAzalt(3, 1);
            label10.Text = sahip.sure.ToString();
            label12.Text = sahip.maliyet.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sahip.Sorgula(sahip.sure, sahip.maliyet, dog.Mide, dog.mutluluk);
            dog.Sev();
            label6.Text = dog.mutluluk.ToString();
            sahip.MSAzalt(0, 1);
            label10.Text = sahip.sure.ToString();
          
        }
        int sayac=0;
        private void button5_Click(object sender, EventArgs e)
        {
            dog.Nextday(Convert.ToInt32(label5.Text), Convert.ToInt32(label6.Text));
            sayac++;
            label5.Text = (dog.Mide).ToString();
            label6.Text = (dog.mutluluk).ToString();
            label8.Text = sayac + ".gün";
            label10.Text = (sahip.sure=4).ToString();
            label12.Text = (sahip.maliyet=2).ToString();
        }
    }
}
