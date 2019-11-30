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

namespace İterationStatements
{
    public partial class frmArraylist : Form
    {
        public frmArraylist()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ArrayList liste = new ArrayList();
            for (int i = 1; i < 150; i++)
            {
                if (i % 2 == 0)
                {
                    listBox2.Items.Add(i);
                }
                else
                {
                    listBox1.Items.Add(i);


            }
            }
        }
    } }
