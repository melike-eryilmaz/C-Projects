using SummerCampDatabaseExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerCampDatabaseExamples.DAL
{
    class EfNotificationDAL
    {
        Denmedb2019Entities db = new Denmedb2019Entities();
        public List<Notifications> GetAll()
        {
            return db.Notifications.ToList();
        }
        public void Add(Notifications notification)
        {
            db.Notifications.Add(notification);
            db.SaveChanges();
        }
        public Notifications Get(byte Id)
        {
           return db.Notifications.Find(Id);


        }
        public void Remove(byte id)
        {
            db.Notifications.Remove(Get(id));
            db.SaveChanges();

        }
        public void Update(Notifications notification)
        {
            var editToNotification = Get(notification.NotificationId);
            editToNotification.Description = notification.Description;
            editToNotification.Title = notification.Title;
            editToNotification.IsActive = notification.IsActive;
            db.SaveChanges(); 
            
        }

    }
}
