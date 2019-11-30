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
    public partial class frmSayıvs : Form
    {
        public frmSayıvs()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                
                lstSayi.Items.Add(Convert.ToInt32(txtAlinan.Text));
                txtAlinan.Clear();

            }
            catch (Exception)
            {

                lstVeri.Items.Add(txtAlinan.Text);
                txtAlinan.Clear();
               
            }
           
            
        }
    }
}
