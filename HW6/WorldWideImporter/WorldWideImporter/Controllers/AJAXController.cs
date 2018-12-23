using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorldWideImporter.Models;

namespace WorldWideImporter.Controllers
{
    public class AJAXController : Controller
    {
        private WWIContext db = new WWIContext();
        // GET: AJAX
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Search(string name)
        {

            Debug.WriteLine(name);
            

            var jsonObj = db.People.Where(p => p.FullName.Contains(name));


            return Json(jsonObj, JsonRequestBehavior.AllowGet);
        }
    }
}