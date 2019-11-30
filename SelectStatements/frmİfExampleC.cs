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
    public partial class frmİfExampleC : Form
    {
        public frmİfExampleC()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmbListe.BackColor = System.Drawing.Color.DeepPink;
            if (checkBox1.Checked)
            {
                cmbListe.Items.Add(txtekle.Text);
            }
            if (checkBox2.Checked)
            {
                listBox1.Items.Add(txtekle.Text);
            }
            else if (!checkBox1.Checked&&!checkBox2.Checked)
            {
                MessageBox.Show("secim yapsana slk.s");
            }
            
          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
             int sayi = Convert.ToInt32(txtSira.Text);
            if (sayi<=listBox1.Items.Count)
            {
                listBox1.Items.RemoveAt(sayi-1);
            }
            else
            {
                MessageBox.Show("Girilen sırada kayıt yok!!!");
            }
        }
    }
}
