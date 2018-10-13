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

        public ActionResult ColorChooser(string color1, string color2)
        {
            ViewBag.trace = false;
            if (color1 != null)
            {
                ViewBag.trace = true;
            }
            Color _color = System.Drawing.ColorTranslator.FromHtml(color1);
            ViewData["color"] = _color;
            return View();

        }
    }
}