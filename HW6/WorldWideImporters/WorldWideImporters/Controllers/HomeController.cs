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

        /// <summary>
        /// This searches for the users in the db
        /// </summary>
        /// <param name="search">the string that is entered to look through the db</param>
        /// <returns>a view with a person that matches the query string</returns>
        // GET: People
        public ActionResult Index(String search)
        {
            //Using my View Model
            ViewModel vm = new ViewModel();


            search = Request.QueryString["search"];
            if (search == null || search == "")
            {
                ViewBag.show = false;
                return View();
            }
            else
            {
                ViewBag.show = true;
                return View(db.People.Where(p => p.FullName.Contains(search)).ToList());
            }
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