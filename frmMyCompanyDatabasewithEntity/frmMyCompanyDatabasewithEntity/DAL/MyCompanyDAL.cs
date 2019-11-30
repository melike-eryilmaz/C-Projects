using frmMyCompanyDatabasewithEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMyCompanyDatabasewithEntity.DAL
{
    class MyCompanyDAL
    {
        MyCompanyEntities db = new MyCompanyEntities();
        //Roles role = new Roles();
        Personels personel = new Personels();

       public List<Personels> GetAll()
        {
            return db.Personels.ToList();
        }
        public void Add(Personels personel)
        {
            db.Personels.Add(personel);
            db.SaveChanges();

        }
        public Personels Get(int id)
        {
            return db.Personels.Find(id);
        }
        public void Remove(int id)
        {
            db.Personels.Remove(Get(id));
            db.SaveChanges();

        }
        public void Update(Personels personel)
        {
            var update = Get(personel.Id);
            update.Name = personel.Name;
            update.Mail = personel.Mail;
            update.Password = personel.Password;
            db.SaveChanges();

        }
    }
}
