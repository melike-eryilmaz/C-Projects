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
    public partial class frmClassProject1 : Form
    {
        public frmClassProject1()
        {
            InitializeComponent();
        }

        private void frmClassProject1_Load(object sender, EventArgs e)
        {
            //ArrayList liste = new ArrayList();
            //liste.Add("melike");
            //liste.Add("melike");

            //foreach (var i in liste)
            //{
            //    MessageBox.Show(i.ToString());
            //}
        }
        ArrayList liste = new ArrayList();


        private void button1_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            int yas = Convert.ToInt32(textBox2.Text);
            liste.Add(isim);
            liste.Add(yas);
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in liste)
            {
                listBox1.Items.Add(item);
                listBox1.Items.Add(item.GetType());
                
            }

            
        }
    }
}
