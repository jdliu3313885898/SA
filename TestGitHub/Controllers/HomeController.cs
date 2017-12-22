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
            i = i + 3;
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