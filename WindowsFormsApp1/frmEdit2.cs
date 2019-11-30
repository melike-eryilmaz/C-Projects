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
    public partial class frmEdit2 : Form
    {
        public frmEdit2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstList.Items.Add(txtAdd.Text);
            label1.Text = lstList.Items.Count.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstList.Items.Clear();
            lstDeleted.Items.Clear();
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            object removedItems = lstList.SelectedItem;
            lstList.Items.Remove(removedItems);
            lstDeleted.Items.Add(removedItems);
            label2.Text = lstDeleted.Items.Count.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = lstList.SelectedIndex;
            string eskiVeri = lstList.SelectedItem.ToString();
            lstList.Items.RemoveAt(index);
            lstList.Items.Insert(index, txtEdit.Text);

            string yeniVeri = txtEdit.Text;
            //lstEdit.Items.Add(eskiVeri);
            //lstEdit.Items.Add(yeniVeri);
           
            string eklenen = eskiVeri + "--------" + yeniVeri;
            lstEdit.Items.Add(eklenen);
            MessageBox.Show("eski kayıt : " + eskiVeri + Environment.NewLine + "yenikayıt:" + yeniVeri);

            // MessageBox.Show(yeniVeri);
            //lstEdit.Items.Add(yeniVeri);
            label3.Text = lstEdit.Items.Count.ToString();
        }

        private void lstList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ///MessageBox.Show("bravo çift tıklayabildin*");
            // int index = lstList.SelectedIndex;
            txtEdit.Text = lstList.SelectedItem.ToString();
        }

        private void frmEdit2_Load(object sender, EventArgs e)
        {

        }

        
    }
}
