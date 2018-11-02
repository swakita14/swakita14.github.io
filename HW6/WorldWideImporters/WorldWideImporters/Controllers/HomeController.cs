using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorldWideImporters.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// This is the context file that connects my db to the project
        /// </summary>
        private WWIContext db = new WWIContext();

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
    }
}