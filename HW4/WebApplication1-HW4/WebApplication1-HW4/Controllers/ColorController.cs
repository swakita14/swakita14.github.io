using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using System.Drawing;
using System.Web.Mvc;
using System.Drawing.Printing;

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
            ViewBag.show = false;
            return View();
        }

        [HttpPost]
        public ActionResult ColorChooser(string color1, string color2)
        {

            color1 = Request.Form["color-input1"];
            color2 = Request.Form["color-input2"];

            Color rgb_color1 = ColorTranslator.FromHtml(color1);
            Color rgb_color2 = ColorTranslator.FromHtml(color2);

            int final_A;
            int final_R;
            int final_B;
            int final_G;

            if (rgb_color1.A + rgb_color2.A >= 255)
            {
                final_A = 255;
            }
            else
            {
                final_A = rgb_color1.A + rgb_color2.A;
            }

            if (rgb_color1.R + rgb_color2.R >= 255)
            {
                final_R = 255;
            }
            else
            {
                final_R = rgb_color1.R + rgb_color2.R;
            }

            if (rgb_color1.B + rgb_color2.B >= 255)
            {
                final_B = 255;
            }
            else
            {
                final_B = rgb_color1.B + rgb_color2.B;
            }

            if (rgb_color1.G + rgb_color2.G >= 255)
            {
                final_G = 255;
            }
            else
            {
                final_G = rgb_color1.G + rgb_color2.G;
            }



            string finale = ColorTranslator.ToHtml(Color.FromArgb(final_A, final_R, final_G, final_B));

            //string finalcolor = color1 + color2;

            
            if (color1 != null && color2!=null)
            {

                ViewBag.show = true;

                Rectangle myRectangle1 = new Rectangle(0,0 ,100, 100);
                Rectangle myRectangle2 = new Rectangle(0, 0, 100, 100);

                Rectangle newShape = new Rectangle(0, 0, 100, 100);

                ViewBag.shape = "width:75px; height: 75px; border: 1px solid #000; background:" + color1 + "; ";
                ViewBag.shape2 = "width:75px; height: 75px; border: 1px solid #000; background: " + color2 + "; ";
                ViewBag.shape3 = "width:75px; height: 75px; border: 1px solid #000; background: " + finale + "; ";



            }
                return View();

        }

       






    }
}