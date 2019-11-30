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
    public partial class frmYeni : Form
    {
        public frmYeni()
        {
            InitializeComponent();
        }
        İslem ye = new İslem();
        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            int baslangic = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            int sayi = Convert.ToInt32(textBox3.Text);

            for (int i = baslangic; i <= bitis; i++)
            {
                list.Add(i);
            }
            MessageBox.Show(ye.Control(list,sayi));
        }
    }
}
