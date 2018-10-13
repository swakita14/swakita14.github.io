using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1_HW4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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


        [HttpGet]
        public ActionResult Converter()
        {

            double miles = Convert.ToInt32(Request.QueryString["miles"]);
     
            string metricUnit = Request.QueryString["metric-unit-radio"];
            double milesToMetric = 0;
            string unit = "";
            ViewBag.Show = false;

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

            ViewData["results"] = (miles + " miles is equal to " + milesToMetric + unit);




            return View();
        }
    }
}