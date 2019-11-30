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
    public partial class frmKrediKart : Form
    {
        public frmKrediKart()
        {
            InitializeComponent();
        }

        private void rbKredi_CheckedChanged(object sender, EventArgs e)
        {
            rbAccess.Enabled=true;
            rbBonus.Enabled=true;
            rbWord.Enabled=true;
        }

        private void rbWord_CheckedChanged(object sender, EventArgs e)
        {
            rbTek.Enabled = true;
            rbTaksit.Enabled = true;


        }

        private void rbAccess_CheckedChanged(object sender, EventArgs e)
        {
            rbTek.Enabled = true;
            rbTaksit.Enabled = true;
        }

        private void rbBonus_CheckedChanged(object sender, EventArgs e)
        {
            rbTek.Enabled = true;
            rbTaksit.Enabled = true;
        }

        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {
            rbAccess.Enabled = false;
            rbBonus.Enabled = false;
            rbWord.Enabled = false;
            rbTek.Enabled = false;
            rbTaksit.Enabled = false; 
            cmbTaksit.Enabled = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string isim = txtİsim.Text;
            float maas = Convert.ToSingle(txtMaas.Text);
            string kur = cmbKur.SelectedItem.ToString();
            switch(kur)
            {
                case "euro":
                    if (rbNakit.Checked)
                    {
                        float yeni = maas * 5.2f;
                        lstEklenen.Items.Add(isim + "----" +yeni);
                        lblNakit.Text = yeni.ToString();
                    }
                    else if (rbKredi.Checked)
                    {
                        if (rbWord.Checked)
                        {
                            if (rbTek.Checked)
                            {
                                float yeni = maas * 1.1f;
                                lstEklenen.Items.Add(isim + "----" + maas * 1.1);
                                lblTaksit.Text = yeni.ToString();
                            }
                            else if(rbTaksit.Checked)
                            {

                                int taksit = Convert.ToInt32(cmbTaksit.SelectedItem);
                                float yeni = (maas * (float)taksit);
                                lstEklenen.Items.Add(isim + "----" + ((maas * 1.1) + (0.1 * taksit)));
                                lblTaksit.Text = yeni.ToString();
                                


                            }


                        }
                        else if (rbAccess.Checked)
                        {
                            if (rbTek.Checked)
                            {
                                lstEklenen.Items.Add(isim + "----" + maas * 1.2);
                            }
                            else if (rbTaksit.Checked)
                            {

                                int taksit = Convert.ToInt32(cmbTaksit.SelectedItem);
                                lstEklenen.Items.Add(isim + "----" + ((maas * 1.2) + (0.1 * taksit)));

                            }
                        }
                        else if (rbBonus.Checked)
                        {
                            if (rbTek.Checked)
                            {
                                lstEklenen.Items.Add(isim + "----" + maas * 1.1);
                            }
                            else if (rbTaksit.Checked)
                            {

                                int taksit = Convert.ToInt32(cmbTaksit.SelectedItem);
                                lstEklenen.Items.Add(isim + "----" + ((maas * 1.3) + (0.1 * taksit)));

                            }
                        }
                    }break;
                case "dolar":
                    if (rbNakit.Checked)
                    {
                        float yeni = maas * 6f;
                        lstEklenen.Items.Add(isim + "----" + yeni);
                        lblNakit.Text = yeni.ToString();
                    }
                    else if (rbKredi.Checked)
                    {
                        if (rbWord.Checked)
                        {
                            if (rbTek.Checked)
                            {
                                lstEklenen.Items.Add(isim + "----" + maas * 1.1);
                            }
                            else if (rbTaksit.Checked)
                            {

                                int taksit = Convert.ToInt32(cmbTaksit.SelectedItem);
                                lstEklenen.Items.Add(isim + "----" + ((maas * 1.1) + (0.1 * taksit)));

                            }


                        }
                        else if (rbAccess.Checked)
                        {
                            if (rbTek.Checked)
                            {
                                lstEklenen.Items.Add(isim + "----" + maas * 1.2);
                            }
                            else if (rbTaksit.Checked)
                            {

                                int taksit = Convert.ToInt32(cmbTaksit.SelectedItem);
                                lstEklenen.Items.Add(isim + "----" + ((maas * 1.2) + (0.1 * taksit)));

                            }
                        }
                        else if (rbBonus.Checked)
                        {
                            if (rbTek.Checked)
                            {
                                lstEklenen.Items.Add(isim + "----" + maas * 1.1);
                            }
                            else if (rbTaksit.Checked)
                            {

                                int taksit = Convert.ToInt32(cmbTaksit.SelectedItem);
                                lstEklenen.Items.Add(isim + "----" + ((maas * 1.3) + (0.1 * taksit)));

                            }
                        }
                    }
                            break;
                case "sterlin":
                    if (rbNakit.Checked)
                    {
                        float yeni = maas * 8.1f;
                        lstEklenen.Items.Add(isim + "----" + yeni);
                        lblNakit.Text = yeni.ToString();
                    }
                    else if (rbKredi.Checked)
                    {
                        if (rbWord.Checked)
                        {
                            if (rbTek.Checked)
                            {
                                lstEklenen.Items.Add(isim + "----" + maas * 1.1);
                            }
                            else if (rbTaksit.Checked)
                            {

                                int taksit = Convert.ToInt32(cmbTaksit.SelectedItem);
                                lstEklenen.Items.Add(isim + "----" + ((maas * 1.1) + (0.1 * taksit)));

                            }


                        }
                        else if (rbAccess.Checked)
                        {
                            if (rbTek.Checked)
                            {
                                lstEklenen.Items.Add(isim + "----" + maas * 1.2);
                            }
                            else if (rbTaksit.Checked)
                            {

                                int taksit = Convert.ToInt32(cmbTaksit.SelectedItem);
                                lstEklenen.Items.Add(isim + "----" + ((maas * 1.2) + (0.1 * taksit)));

                            }
                        }
                        else if (rbBonus.Checked)
                        {
                            if (rbTek.Checked)
                            {
                                lstEklenen.Items.Add(isim + "----" + maas * 1.1);
                            }
                            else if (rbTaksit.Checked)
                            {

                                int taksit = Convert.ToInt32(cmbTaksit.SelectedItem);
                                lstEklenen.Items.Add(isim + "----" + ((maas * 1.3) + (0.1 * taksit)));

                            }
                        }
                    }
                            break;
                default:
                    MessageBox.Show("kur seç");break;


            }
        }

        private void rbTaksit_CheckedChanged(object sender, EventArgs e)
        {
            cmbTaksit.Enabled = true;
        }
    }
}
