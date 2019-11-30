using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmToplama : Form
    {
        public frmToplama()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Convert.ToInt32(txtBirinciSayi.Text)+Convert.ToInt32(txtİkinciSayi.Text)).ToString());
        }

        private void frmToplama_Load(object sender, EventArgs e)
        {

        }
    }
}
