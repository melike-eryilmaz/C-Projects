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
    public partial class frmListBoxExample2 : Form
    {
        public frmListBoxExample2()
        {
            InitializeComponent();
        }

        private void frmListBoxExample2_Click(object sender, EventArgs e)
        {
            //string userName = txtUserName.Text;
            //string password = txtPassword.Text;
            //string result = "Adınız:  " + userName + "Sifreniz:  " + password;
            //lstListe.Items.Add(result);
           // lstListe.Items.Add("Adınız:  " + txtUserName.Text + "Sifreniz:  " + txtPassword.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string result = "Adınız:  " + userName + "Soyadınız:  " + password;
            lstListe.Items.Add(result);
            //lstListe.Items.Add("Adınız:  " + txtPassword.Text + "Soyadınız:  " + txtPassword.Text);
        }

        private void frmListBoxExample2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // int index = lstListe.SelectedIndex;
            //lstListe.Items.RemoveAt(index);

            //lstListe.Items.Remove(lstListe.SelectedItem);
            object removeToItem = lstListe.SelectedItem;

            lstListe.Items.Remove(removeToItem);
            lstListe2.Items.Add(removeToItem);
            

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstListe.Items.Clear();
            lstListe2.Items.Clear();

        }
    }
}
