using SetLists.DAL;
using SetLists.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SetLists.Controllers
{
    public class HomeController : Controller
    {
        private MusicContext db = new MusicContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Song()
        {
            return View(db.Songs.ToList());
        }

        public ActionResult SetList()
        {
            return View(db.SetLists.ToList());
        }
    }
}
