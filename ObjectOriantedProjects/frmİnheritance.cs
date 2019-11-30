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
    public partial class frmİnheritance : Form
    {
        public frmİnheritance()
        {
            InitializeComponent();
        }

        private void frmİnheritance_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            İslem islem1 = new İslem();
            islem1.Islem = textBox1.Text;
            MessageBox.Show(islem1.Islem);
        }
    }
}
