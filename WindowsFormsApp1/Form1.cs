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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ///design yazan olusturan method
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Value Types
            bool isActive = false;
            byte yas = 25;
            sbyte derece = -17;
            short eksiliSayi = 0;
            int sayi = 321456789;
            long buyukSayi = 799465142321212;

            #endregion
            #region Floating Types
            float floatSayi = 21456.2456f;
            double doubleSayi = 32145612.5d;
            decimal decimalSayi = 4567899.12m;
            #endregion
            #region Reference Types
            char karakter = 'v';
            string kelime = "bchdckjdn54";

            #endregion

        }
    }
}
