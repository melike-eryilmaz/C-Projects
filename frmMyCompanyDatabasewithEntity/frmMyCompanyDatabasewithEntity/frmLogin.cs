using frmMyCompanyDatabasewithEntity.DAL;
using frmMyCompanyDatabasewithEntity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMyCompanyDatabasewithEntity
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        MyCompanyEntities db = new MyCompanyEntities();


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mail = txtUserName.Text;
            string password = txtPassword.Text;
            var user = db.Personels.FirstOrDefault(a => a.Mail == mail && a.Password == password);

            if (user!=null)
            {
                if (user.RoleId == 1)
                {
                    frmBossOperations yeni = new frmBossOperations();
                    yeni.Show();

                }
                else
                {
                    frmEmployeeOperations yeni = new frmEmployeeOperations();
                    yeni.Show();
                }

            }
            else
            {
                label1.Text = "yanlış";
            }

        }
    }
}
