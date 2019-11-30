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
    public partial class frmSwitchExample : Form
    {
        public frmSwitchExample()
        {
            InitializeComponent();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            string selectMonts = cmbMonths.SelectedItem.ToString();
            string SwitchSuresi;
            //instance alma 
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            switch (selectMonts)
            {
                case "ocak":
                    MessageBox.Show("ay ocak");break;
                case "şubat":
                    MessageBox.Show("ay şubat"); break;
                case "mart":
                    MessageBox.Show("ay mart"); break;
                case "nisan":
                    MessageBox.Show("ay nisan"); break;
                case "mayıs":
                    MessageBox.Show("ay mayıs"); break;
                default:
                    MessageBox.Show("seçim yap çiçek");
                    break;
            }
            stopwatch.Stop();
            SwitchSuresi =stopwatch.Elapsed.ToString();
            MessageBox.Show(SwitchSuresi);
            // ram de üst sıraya taşıdı.süreler arası fark azaldı.
        }
    }
}
