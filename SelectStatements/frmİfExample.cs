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
    public partial class frmİfExample : Form
    {
        public frmİfExample()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (chkLeftListBox.Checked)
            {
                lstLeft.Items.Add(txt1.Text);
            }
            if (chkRightListBox.Checked)
            {
                lstRight.Items.Add(txt1.Text);
            }
            if (!chkRightListBox.Checked && !chkLeftListBox.Checked)
            {
                MessageBox.Show("Lütfen seçim yapar mısın???");
            }
           
        }
    }
}
