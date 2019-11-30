using RegTemp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegTemp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        UsersDatabaseEntities db = new UsersDatabaseEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string userName, string mail, string password, string conpassword)
        {
            db.Users.Add(new Users
            {
                Name = userName,
                email = mail,
                password = password,
                Repassword = conpassword,
            });
            db.SaveChanges();
            return RedirectToAction("Login", "Home");
        }

        public ActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            var user = db.Users.FirstOrDefault(a => a.email == email && a.password == password);
            if (user!=null)
            {

                return RedirectToAction("LoginPageOne", "Home",new { id=user.userId});

            }
            else
            {
                ViewBag.hata = "Girilen bilgiler eksik ya da geçersiz";
                return View();
            }
        }

        public ActionResult LoginPageOne(byte ?id)

        {
            Users user = db.Users.Find(id);
            UserArticle model = new UserArticle
            {
                users = user,
                articles = db.Article.Where(a => a.userId == user.userId).ToList()

            };
            return View(model);
        }
      

        public ActionResult Article(byte? id)
        {
            Article article = db.Article.Find(id);

            return View(article);
        }
        public ActionResult CreateArticle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateArticle(string title,string description)
        {
            db.Article.Add(new Article
            {
                title = title,
                Description = description
            });
            db.SaveChanges();
            ViewBag.yeni = "yeni makale eklendi";
            return View();
        }
    }
}