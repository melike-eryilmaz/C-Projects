using SummerCampDatabaseExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerCampDatabaseExamples.DAL
{
    class EfFrequentlyAskedQuestionsDAL
    {

        Denmedb2019Entities db = new Denmedb2019Entities();
        
        public List<Faqs> GetAll()
        {
            return db.Faqs.ToList();
            

        }
        public void Add(Faqs faqs)
        {
            db.Faqs.Add(faqs);
            db.SaveChanges();
        }
        public Faqs Get(int Id)
        {
            return db.Faqs.Find(Id);


        }
        public void Remove(int id)
        {
            db.Faqs.Remove(Get(id));
            db.SaveChanges();

        }
        public void Update(Faqs faqs)
        {
            var editTofaq = Get(faqs.Id);
            editTofaq.Answer = faqs.Answer;
            editTofaq.Question = faqs.Question;
            editTofaq.IsActive = faqs.IsActive;
            db.SaveChanges();

        

         }
}
}
