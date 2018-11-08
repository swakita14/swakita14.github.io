using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace AJAX_WebApp.Controllers
{
    public class AJAXController : Controller
    {
        
        // GET: AJAX
        /// <summary>
        /// This is the View of the homepage
        /// </summary>
        /// <returns>a View of the index</returns>
        public ActionResult Index()
        {
            return View();
        }

        
    }
}