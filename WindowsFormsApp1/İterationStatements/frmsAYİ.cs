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
    public partial class frmsAYİ : Form
    {
        public frmsAYİ()
        {
            InitializeComponent();
        }

        private void frmsAYİ_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                lst2.Items.Add(i);
            }

            for (int j =100; j>1; j--)
            {
                lst1.Items.Add(j);
            }
        }
    }
}
