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
    public partial class frmEditExample : Form
    {
        public frmEditExample()
        {

            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstList.Items.Add(txtAdd.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            object removedItems = lstList.SelectedItem;
            lstList.Items.Remove(removedItems);
            lstDeleted.Items.Add(removedItems);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstList.Items.Clear();
            lstDeleted.Items.Clear();
         
        }
        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    int index = lstList.SelectedIndex;
        //    lstList.Items.RemoveAt(index);
        //    lstList.Items.Insert(index, txtEdit.Text);


        //}



        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtEdit.Text = lstList.SelectedItem.ToString();
            }
            catch (Exception)
            {


            }
        }

        private void lstList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("BRAVO");
            int index = lstList.SelectedIndex;
            lstList.Items.RemoveAt(index);
            lstList.Items.Insert(index, txtEdit.Text);
        }
    }
}
