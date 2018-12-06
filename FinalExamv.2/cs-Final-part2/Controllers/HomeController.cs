using cs_Final_part2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cs_Final_part2.Controllers
{


    public class HomeController : Controller
    {
        private MissionContext db = new MissionContext();

        public ActionResult Index()
        {
            ViewBag.Mission = new SelectList(db.Missions, "MissionID", "Designation");
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