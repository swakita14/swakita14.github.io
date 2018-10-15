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

        /// <summary>
        /// This is the GET page for the ColorChooser path
        /// </summary>
        /// <returns>returns the view of the ColorChooser.cshtml ViewPage</returns>
        [HttpGet]
        public ActionResult ColorChooser()
        {
            ViewBag.show = false;
            return View();
        }


        /// <summary>
        /// This is the POST Action, which takes the user input and shows the 3 squares: 2 input and 1 resulting colored square
        /// </summary>
        /// <param name="color1">this is the one of the two colors the user's input to do the addition of colots</param>
        /// <param name="color2">this is the second color of the two, the user's input to do the addition of colots</param>
        /// <returns>returns the View of the controller with the result of the user's input</returns>
        [HttpPost]
        public ActionResult ColorChooser(string color1, string color2)
        {

            //takes the user input and assigns it to local variable
            color1 = Request.Form["color-input1"];
            color2 = Request.Form["color-input2"];

            //changes hex to argb format to do some addition with it
            Color rgb_color1 = ColorTranslator.FromHtml(color1);
            Color rgb_color2 = ColorTranslator.FromHtml(color2);

            //this is the final argb values for the resulting square
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


            //converts the calculated argb value back to hex
            string finale = ColorTranslator.ToHtml(Color.FromArgb(final_A, final_R, final_G, final_B));

           

            
            if (color1 != null && color2!=null)
            {
                //makes the result appear
                ViewBag.show = true;

                //assigns colors and shapes to the div element in the View
                ViewBag.shape = "width:75px; height: 75px; border: 1px solid #000; background:" + color1 + "; ";
                ViewBag.shape2 = "width:75px; height: 75px; border: 1px solid #000; background: " + color2 + "; ";
                ViewBag.shape3 = "width:75px; height: 75px; border: 1px solid #000; background: " + finale + "; ";



            }
                return View();

        }

       






    }
}