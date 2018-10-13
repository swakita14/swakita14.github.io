using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Web.Mvc;

namespace WebApplication1_HW4.Controllers
{
    public class ColorController : Controller
    {
        // GET: Color
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ColorChooser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ColorChooser(string color1, string color2)
        {
            Color color = ColorTranslator.FromHtml(color1);
            return View(color);
        }

       
    }
}