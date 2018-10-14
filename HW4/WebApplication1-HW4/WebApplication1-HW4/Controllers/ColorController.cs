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
            return View("Hello World");
        }

        [HttpGet]
        public ActionResult ColorChooser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ColorChooser(string color1, string color2)
        {
            color1 = Request.Form["color-input1"];
            color2 = Request.Form["color-input2"];

            ViewBag.show = false;
            if (color1 != null)
            {
                Color color = ColorTranslator.FromHtml(color1);
                ViewBag.show = true;
                ViewBag.test = color1;
                ViewData["test"] = color;
            }
            return View();
        }

       
    }
}