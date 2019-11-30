using MelikeEryilmaz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MelikeEryilmaz.Controllers
{
    public class AnasayfaController : Controller
    {
        // GET: Anasayfa
        August_30_DbEntities db = new August_30_DbEntities();

        public ActionResult Index()
        {
            Sliders slider = new Sliders();
            return View(slider);
        }
    }
}