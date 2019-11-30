using MvcGetPostwithDatabase.DAL;
using MvcGetPostwithDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcGetPostwithDatabase.Controllers
{
    public class HomeController : Controller
    {

        UsersEntities yeni= new UsersEntities();
        Users user = new Users();
        UserEntitiyDal nesne = new UserEntitiyDal();
   
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index1()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }




        [HttpPost]   
        
        public ActionResult Index(string userName, string password)

        {
            if (user.Name == userName && user.Password == password)
            {
                return View("Index1");
            }
            else
            {
                ViewBag.Hata = "hatalı giris";

                return View("Index2");
            }

        }
      

    }
}