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
    public partial class frmSayiString : Form
    {
        public frmSayiString()
        {
            InitializeComponent();
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            int  sayi = Convert.ToInt32(txtSayi.Text);
            int binler = sayi /1000;
            sayi = sayi - binler * 1000;
            int yuzler = sayi / 100;
            sayi = sayi - yuzler * 100;
            int onlar = sayi / 10;
            int birler = sayi - onlar * 10;

            switch (binler) { 

            
                case 1:
                    lblString.Text ="Bin";break;
                case 2:             
                    lblString.Text ="iki bin"; break;
                case 3:             
                    lblString.Text ="üç bin"; break;
                case 4:             
                    lblString.Text ="dört bn"; break;
                case 5:             
                    lblString.Text ="beş bin"; break;
                case 6:             
                    lblString.Text ="altı bin"; break;
                case 7:             
                    lblString.Text ="yedi bin"; break;
                case 8:           
                    lblString.Text ="sekiz bin"; break;
                case 9:
                    lblString.Text = "dokuz bin"; break;
            }

                switch (yuzler)
                {


                    case 1:
                        lblString.Text = lblString.Text+ " yüz"; break;
                    case 2:
                        lblString.Text = lblString.Text + " iki yüz "; break;
                    case 3:
                        lblString.Text = lblString.Text + " üç yüz "; break;
                    case 4:
                        lblString.Text = lblString.Text + " dört yüz "; break;
                    case 5:
                        lblString.Text = lblString.Text + " beş yüz "; break;
                    case 6:
                        lblString.Text = lblString.Text + " altı yüz "; break;
                    case 7:
                        lblString.Text = lblString.Text + " yedi yüz "; break;
                    case 8:
                        lblString.Text = lblString.Text + " sekiz yüz "; break;
                    case 9:
                        lblString.Text = lblString.Text + " dokuz yüz "; break;
                }


                    switch (onlar)

                    {
                                case 1:
                                    lblString.Text = lblString.Text + "on ";break;                          
                                case 2:
                                    lblString.Text = lblString.Text + "yirmi "; break;
                                case 3:
                                    lblString.Text = lblString.Text + "otuz "; break;
                                case 4:
                                    lblString.Text = lblString.Text + "kırk "; break;
                                case 5:
                                    lblString.Text = lblString.Text + "elli "; break;
                                case 6:
                                    lblString.Text = lblString.Text + "altmış "; break;
                                case 7:
                                    lblString.Text = lblString.Text + "yetmiş "; break;
                                case 8:
                                    lblString.Text = lblString.Text + "seksen "; break;
                                case 9:
                                    lblString.Text = lblString.Text + "doksan "; break;

                    }
                        switch (birler) { 
                                   case 1:
                                        lblString.Text = lblString.Text + "Bir";
                                        break;
                                    case 2:
                                        lblString.Text = lblString.Text + "iki"; break;
                                    case 3:
                                        lblString.Text = lblString.Text + "üç"; break;
                                    case 4:
                                        lblString.Text = lblString.Text + "dört"; break;
                                    case 5:
                                        lblString.Text = lblString.Text + "beş"; break;
                                    case 6:
                                        lblString.Text = lblString.Text + "altı"; break;
                                    case 7:
                                        lblString.Text = lblString.Text + "yedi"; break;
                                    case 8:
                                        lblString.Text = lblString.Text + "sekiz"; break;
                                    case 9:
                                        lblString.Text = lblString.Text + "dokuz"; break;
                                    

            }


        }
    }
}
