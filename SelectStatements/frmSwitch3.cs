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
    public partial class frmSwitch3 : Form
    {
        public frmSwitch3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            bool chk1 = checkBox1.Checked;
            bool chk2 = checkBox2.Checked;
            bool chk3 = checkBox3.Checked;
            bool chk4 = checkBox4.Checked;
            
            switch (chk1)

            {
                case true:
                    listBox1.Items.Add(sayi1 + sayi2);
                    break;
                
                

            }
            switch (chk2)

            {
                case true:
                    listBox2.Items.Add(sayi1 - sayi2);
                    break;



            }
            switch (chk3)

            {
                case true:
                    listBox3.Items.Add(sayi1 * sayi2);
                    break;



            }
            switch (chk4)

            {
                
                case true:
                    listBox4.Items.Add((float)sayi1 / (float)sayi2);
                    break;



            }

        }
    }
}
