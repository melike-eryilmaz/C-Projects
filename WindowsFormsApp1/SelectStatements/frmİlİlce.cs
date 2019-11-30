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
    public partial class frmİlİlce : Form
    {
        public frmİlİlce()
        {
            InitializeComponent();
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            //lstAdres.Items.Add();
        }

       
        private void cmbİl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbİlce.Items.Clear();
            if (cmbİl.SelectedItem == "Antalya")
            {
                cmbİlce.Enabled = true;
                cmbİlce.Items.Add("ilce1");
                cmbİlce.Items.Add("illce2");
                cmbİlce.Items.Add("illce3");
                cmbİlce.Items.Add("illce4");
                cmbİlce.Items.Add("illce5");
               

            }
            else if (cmbİl.SelectedItem=="İzmir")
            {
                cmbİlce.Enabled = true;
            
                cmbİlce.Items.Add("ilce1");
                cmbİlce.Items.Add("illce2");
                cmbİlce.Items.Add("illce3");
                cmbİlce.Items.Add("illce4");
                cmbİlce.Items.Add("illce5");
               

            }
            else if (cmbİl.SelectedItem == "İstanbul")
            {
                cmbİlce.Enabled = true;

                cmbİlce.Items.Add("ilce1");
                cmbİlce.Items.Add("illce2");
                cmbİlce.Items.Add("illce3");
                cmbİlce.Items.Add("illce4");
                cmbİlce.Items.Add("illce5");
            
            }
            else if (cmbİl.SelectedItem == "Zonguldak")
            {
                cmbİlce.Enabled = true;

                cmbİlce.Items.Add("ilce1");
                cmbİlce.Items.Add("illce2");
                cmbİlce.Items.Add("illce3");
                cmbİlce.Items.Add("illce4");
                cmbİlce.Items.Add("illce5");


            }
        }

        private void cmbİlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSokak.Enabled = true;
        }

        private void txtSokak_TextChanged(object sender, EventArgs e)
        {
            txtApart.Enabled = true;
        }
    }
}
