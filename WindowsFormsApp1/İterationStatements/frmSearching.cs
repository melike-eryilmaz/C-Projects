using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İterationStatements
{
    public partial class frmSearching : Form
    {
        public frmSearching()
        {
            InitializeComponent();
        }
        string[] dizi;
        private void btn_Click(object sender, EventArgs e)
        {
            lstAranan.Items.Add(txtAdd.Text);
            dizi = new string[lstAranan.Items.Count];
            for (int i = 0; i < lstAranan.Items.Count; i++)
            {
                dizi[i] = lstAranan.Items[i].ToString();
            }
        }
        

        

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            lstAranan.Items.Clear();
            string aranan = txtAra.Text;
            int boyut = aranan.Length;
           // char[] dizims = new char[boyut];
           // dizims = aranan.ToCharArray();
            foreach (var i in dizi)
            {
                for (int j = 0; j < aranan.Length; j++)
                {

                    if (i.StartsWith(aranan))
                    { 
                            lstAranan.Items.Add(i);break;

                        

                    }

                    //if (i[j]==aranan[j])
                    //{
                    //    lstAranan.Items.Add(i);
                    //}
                }

            }
        }
    }
}
