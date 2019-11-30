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
    public partial class frmArrays : Form
    {
        public frmArrays()
        {
            InitializeComponent();
        }
        string[] dizi;


        private void frmArrays_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }


        

        private void button2_Click(object sender, EventArgs e)

        {
            int count = listBox1.Items.Count;
            dizi = new string[count];

            for (int i = 0; i <count ; i++)
            {
                dizi[i]= listBox1.Items[i].ToString();
            }
            MessageBox.Show(dizi.Length + "elemanlı diziniz var");
           // MessageBox.Show(dizi.Count()+ "elemanlı diziniz var");
          


        }



        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = dizi.Count() ; i > 0; i--)
            {
                listBox2.Items.Add(dizi[i-1]);
            }
        }
    }
}
