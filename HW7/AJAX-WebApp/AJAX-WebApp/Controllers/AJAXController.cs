using System;
using System.Collections.Generic;
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
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// This will take the user input and place it in the URI and send a JSON request
        /// and parse through it and get the data that we want. 
        /// </summary>
        /// <returns>JSON obj with the information needed</returns>
        public JsonResult Search()
        {
            string apiKey = "nlFMJaljRdG7yYkuQ2DvUspGg6Ti5qkj"; // Some way to hide the key?


            //Takes in the user input 
            string searchString = Request.QueryString["text-input"];

            //Creates the URL for the search function using my own API
            string getURL = "https://api.giphy.com/v1/stickers/translate?api_key=" + apiKey + "&s=" + searchString;

            //Makes a request to the URL and receives the responce
            WebRequest request = WebRequest.Create(getURL);
            WebResponse getResponce = request.GetResponse();

            Stream data = request.GetResponse().GetResponseStream();

            //Convert the response to a string 
            string convString = new StreamReader(data).ReadToEnd();

            //lets parse through the JSON ojbect that we received from the endpoint
            var serialize = new System.Web.Script.Serialization.JavaScriptSerializer();
            var jsonObj = serialize.DeserializeObject(convString);

            //Closing stream
            data.Close();
            getResponce.Close();

            //returns JSON obj
            return Json(jsonObj, JsonRequestBehavior.AllowGet);


        }
    }
}