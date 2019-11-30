using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectStatements
{
    public partial class frmSwitchex2 : Form
    {
        public frmSwitchex2()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            float para = Convert.ToSingle(txtPara.Text);
            string kur = cmbKur.SelectedItem.ToString();
            string isim = txtİsim.Text;

            Stopwatch timer = new Stopwatch();
            string ifelsesure, switchsure;

            if (rbİfElse.Checked)
            {
                timer.Start();

                if (kur == "dolar")
                {
                    lstİsim.Items.Add(isim);
                    lstTutar.Items.Add(para * 5);
                    lstBirim.Items.Add("$");
                }
                else if (kur == "euro")
                {
                    lstİsim.Items.Add(isim);
                    lstTutar.Items.Add(para * 6);
                    lstBirim.Items.Add("e");

                }
                else
                {
                    lstİsim.Items.Add(isim);
                    lstTutar.Items.Add(para * 8);
                    lstBirim.Items.Add("£");

                }
                timer.Stop();
                ifelsesure = timer.Elapsed.ToString();
                MessageBox.Show("if else:" + ifelsesure);

            }
            bool dogru = rbSwitchCase.Checked;
            switch (dogru)
            {
                case true:

                    timer.Start();
                    switch (kur)
                    {

                        case "euro":
                            lstİsim.Items.Add(isim);
                            lstTutar.Items.Add(para * 5);
                            lstBirim.Items.Add("$");
                            break;
                        case "dolar":
                            lstİsim.Items.Add(isim);
                            lstTutar.Items.Add(para * 6);
                            lstBirim.Items.Add("e");
                            break;
                        case "sterlin":
                            lstİsim.Items.Add(isim);
                            lstTutar.Items.Add(para * 8);
                            lstBirim.Items.Add("£");
                            break;

                        default:
                            break;
                    }
                    break;
                    timer.Stop();
                    switchsure = timer.Elapsed.ToString();
                    MessageBox.Show("switch:" + switchsure);



            }


        }
    }
}
