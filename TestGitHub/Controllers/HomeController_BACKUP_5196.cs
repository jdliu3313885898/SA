using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestGitHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int i = 0;
            i = i + 1;
            i = i + 2;
            i = i + 5;
            i = i + 6;
            i = i + 4;
<<<<<<< HEAD
            i = i + 8;
=======
            i = i + 7;
>>>>>>> d5435151303a1bb2079a6e647c00c8560d714826
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}