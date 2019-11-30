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
    public partial class frmSerhatornek2 : Form
    {
        public frmSerhatornek2()
        {
            InitializeComponent();
        }
        string user1 = "ali";
        string user2 = "veli";
        string password2 = "234";
        string password = "123";
        int  hak = 3;
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text==user1&&txtPassword.Text==password|| txtKullanici.Text == user2 && txtPassword.Text == password2&&hak!=0)
            {
                MessageBox.Show("dogru giriş");
            }
           
            else
            {
                hak = hak - 1;

                MessageBox.Show("giriş yanlış "+hak +"kaldı");
                if (hak==0)
                {
                    btnLogin.Enabled = false;
                }


            }
        }
    }
}
