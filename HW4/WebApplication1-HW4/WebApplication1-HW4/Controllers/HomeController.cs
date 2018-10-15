using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1_HW4.Controllers
{
    public class HomeController : Controller
    {
<<<<<<< HEAD

        /// <summary>
        /// This gets the user input and outputs the result. Using query strings takes in miles and returns metric units
        /// </summary>
        /// <returns>returns the view page of the converter.</returns>
        [HttpGet]
        public ActionResult Converter()
        {
            //Takes in user input miles
            double miles = Convert.ToInt32(Request.QueryString["miles"]);

            //this recognizes the value of the radio button that the user has selected, in order to see which unit we are converting to
            string metricUnit = Request.QueryString["metric-unit-radio"];
            double milesToMetric = 0;
            string unit = "";
            ViewBag.Show = false;

            //radion button value checking
            if (metricUnit == "mm")
            {
                unit = "mm";
                milesToMetric = (miles * 1609344);
                ViewBag.Show = true;

            }
            else if (metricUnit == "cm")
            {
                unit = "cm";
                milesToMetric = (miles * 160934.4);
                ViewBag.Show = true;


            }
            else if (metricUnit == "mt")
            {
                unit = "m";
                milesToMetric = (miles * 1609.344);
                ViewBag.Show = true;

            }
            else if (metricUnit == "km")
            {
                unit = "km";
                milesToMetric = (miles * 1.609344);
                ViewBag.Show = true;
            }

            //output the results of the convertion
            ViewData["results"] = (miles + " miles is equal to " + milesToMetric + unit);

            return View();
        }
    }
}