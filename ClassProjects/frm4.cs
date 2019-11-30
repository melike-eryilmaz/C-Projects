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
    public partial class frm4 : Form
    {
        public frm4()
        {
            InitializeComponent();
        }
        ArrayList list = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            listBox2.Items.Add(sayi);
        }
        int secili1,secili2;
        int tık = 0;
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem!=null)
            {
                secili1 = Convert.ToInt32(listBox2.SelectedItem);

            }
            //listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            // listBox2.SelectedItem= false;
            //listBox2.SetSelected(0, false);


        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float sonuc;
            string operation = listBox1.SelectedItem.ToString();
            
           // listBox2.SetSelected(listBox2.SelectedIndex, false);
           // listBox2.SelectedItem = false;



            if (operation=="+")
            {
                sonuc = secili1 + secili2;
                list.Add(sonuc);
            }
            else if (operation=="-")
            {
                sonuc = secili1 - secili2;
                list.Add(sonuc);


            }
            else if (operation=="*")
            {
                sonuc = secili1 *secili2;
                list.Add(sonuc);



            }
            else if (operation=="/")
            {
                sonuc = secili1 / secili2;

                list.Add(sonuc);

            }
            secili2 = Convert.ToInt32(listBox2.SelectedItem);
            foreach (var item in list)
            {
                MessageBox.Show(item.ToString());
            }
        }
    }
}
