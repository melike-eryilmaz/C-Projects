using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassProjects
{
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void frm3_Load(object sender, EventArgs e)
        {
            ArrayList list1 = new ArrayList() { 1,2,3,4,5,6,7,8,9,10};
            ArrayList list2 = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (var i in list1)
            {
                foreach (var k in list2)
                {
                    string met = i.ToString() + "X" + k.ToString() + "=" +(Convert.ToInt32(i)* Convert.ToInt32(k));
                    listBox1.Items.Add(met);

                }
                listBox1.Items.Add("******************************");
            }
        }
    }
}
