using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FullMVCProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ViewResult ManCity()
        {
            ViewBag.Title = "Snap Scoccer";
            ViewBag.WelcomeMessage = "Welcome to the shop!. Check out our PLayers";
            ViewData["CurrentTime"] = DateTime.Now;
            return View();
        }
    }
}