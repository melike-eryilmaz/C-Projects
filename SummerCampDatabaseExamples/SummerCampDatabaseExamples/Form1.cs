using SummerCampDatabaseExamples.DAL;
using SummerCampDatabaseExamples.Models;
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

namespace SummerCampDatabaseExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EfNotificationDAL efNotificationDAL = new EfNotificationDAL();

        private void Form1_Load(object sender, EventArgs e)
        {
            //  Denmedb2019Entities db = new Denmedb2019Entities();
            dgvNotificationList.DataSource =efNotificationDAL.GetAll();
            

            //CREATE --İNSERTİNG DATA
            /* Notifications yeni = new Notifications() {Title="dbbsnbcvn",Description="dbsvdvbb",IsActive=true };

             yeni.Title = "hello everyone";
             yeni.Description = "açıklama eklendi";
             yeni.IsActive = true;
             yeni.RegisterDate = DateTime.Parse("2019-10-5");
             db.Notifications.Add(yeni);*/

            //READ--SELECTİNG DATA
            /*Notifications yeni = new Notifications();
            yeni=db.Notifications.Find(1);
            MessageBox.Show(yeni.NotificationId+" "+yeni.Title+" "+yeni.Description+" " +yeni.RegisterDate);*/

            //UPDATİNG DATA
           /* Notifications yeni = new Notifications();
            yeni = db.Notifications.Find(1);
            MessageBox.Show(yeni.NotificationId + " " + yeni.Title + " " + yeni.Description + " " + yeni.RegisterDate); 
            yeni.Description = "Fotoğraflarınız arşivlendi";
            yeni.Title = "media";
            yeni.IsActive = false;
            db.SaveChanges();
            MessageBox.Show(yeni.NotificationId+" "+yeni.Title+" "+yeni.Description+" " +yeni.RegisterDate);*/
            
            //DELETİNG DATA
           /* Notifications yeni = new Notifications();
            yeni = db.Notifications.Find(3);
            db.Notifications.Remove(yeni);
            db.SaveChanges();
            MessageBox.Show("Test");*/
        }
         Notifications notification = new Notifications();
        byte notificationId;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*Notifications notification = new Notifications();
            notification.Title = txtTitle.Text;
            notification.Description = txtDes.Text;
            notification.IsActive = chkIsActive.Checked;
            notification.RegisterDate = DateTime.Now;
            efNotificationDAL.Add(notification);*/
            efNotificationDAL.Add(new Notifications
            {
                Title = txtTitle.Text,
                Description = txtDes.Text,
                IsActive = chkIsActive.Checked,
                RegisterDate = DateTime.Now
            });
            dgvNotificationList.DataSource =efNotificationDAL.GetAll();

        }

      

        private void dgvNotificationList_DoubleClick(object sender, EventArgs e)
        {
            notificationId = Convert.ToByte(dgvNotificationList.CurrentRow.Cells[0].Value);
            txtEdit.Text = dgvNotificationList.CurrentRow.Cells[1].Value.ToString();
            txted.Text = dgvNotificationList.CurrentRow.Cells[2].Value.ToString();
            chked.Checked = Convert.ToBoolean(dgvNotificationList.CurrentRow.Cells[3].Value);
           


        }

        private void btnup_Click(object sender, EventArgs e)
        {

            efNotificationDAL.Update(new Notifications {
                Description = txtEdit.Text,
                IsActive=chked.Checked,
                Title=txted.Text
            });
            dgvNotificationList.DataSource = efNotificationDAL.GetAll();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            efNotificationDAL.Remove(notificationId);
        }
    }
}
