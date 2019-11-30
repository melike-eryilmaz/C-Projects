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
    public partial class frmStringConcatination : Form
    {
        public frmStringConcatination()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            lstListe.Items.Add("Adınız :   " +txtKullaniciAdi.Text+ "     Şifreniz: "+txtSifre.Text);
            
        }
    }
        
}
