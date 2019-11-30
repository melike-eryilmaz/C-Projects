using MelikeEryilmaz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MelikeEryilmaz.Controllers
{
    public class AboutUsController : Controller
    {
        August_30_DbEntities db = new August_30_DbEntities();

        // GET: AboutUs
        public ActionResult Index()
        {
            return View(db.Abouts.ToList());
        }
    }
}