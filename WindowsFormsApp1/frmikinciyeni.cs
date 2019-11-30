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
    public partial class frmikinciyeni : Form
    {
        public frmikinciyeni()
        {
            InitializeComponent();
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);

            listBox1.Items.Remove(listBox1.SelectedItem);


          
          //stBox2.Items.Remove(listBox1.SelectedItem); 
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
  
        }
    }
}
