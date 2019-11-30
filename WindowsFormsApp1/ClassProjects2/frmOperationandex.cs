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
    public partial class frmOperationandex : Form
    {
        public frmOperationandex()
        {
            InitializeComponent();
        }
        frmOPandex yeni = new frmOPandex();
        ArrayList liste = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList list1 = new ArrayList();
            list1 = yeni.İslemYap(liste);
            // MessageBox.Show(list1.Count.ToString());
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                liste.Add(listBox1.Items[i]);
            }
            for (int i = 0; i < list1.Count; i++)
            {
                listBox2.Items.Add(list1[i]);
            }

        }
    }
}
