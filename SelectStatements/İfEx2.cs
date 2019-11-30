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
    public partial class İfEx2 : Form
    {
        public İfEx2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                if (chkBottom.Checked)
                {
                    lstBottom.Items.Add(textBox1.Text);
                }
                if (chkLeft.Checked)
                {
                    lstLeft.Items.Add(textBox1.Text);

                }
                if (chkRight.Checked)
                {
                    lstRight.Items.Add(textBox1.Text);

                }
                if (chkTop.Checked)
                {
                    lstTop.Items.Add(textBox1.Text);

                }

            }
            if (radioButton2.Checked)
            {
                if (!chkBottom.Checked)
                {
                    lstBottom.Items.Add(textBox1.Text);
                }
                if (!chkLeft.Checked)
                {
                    lstLeft.Items.Add(textBox1.Text);

                }
                if (!chkRight.Checked)
                {
                    lstRight.Items.Add(textBox1.Text);

                }
                if (!chkTop.Checked)
                {
                    lstTop.Items.Add(textBox1.Text);

                }

            }

        }

       
    }
}
