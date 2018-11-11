using AJAX_WebApp.DAL;
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
    public class TranslateController : Controller
    {
        private LogDbContext db = new LogDbContext();
        // GET: Translate
        /// <summary>
        /// This will take the user input and place it in the URI and send a JSON request
        /// and parse through it and get the data that we want. 
        /// </summary>
        /// <returns>JSON obj with the information needed</returns>
        public JsonResult Sticker(string txt)
        {
            //You are not getting my ApiKey
            string apiKey = System.Web.Configuration.WebConfigurationManager.AppSettings["APIKEY"];


            //Creates the URL for the search function using my own API
            string getURL = "https://api.giphy.com/v1/stickers/translate?api_key=" + apiKey + "&s=" + txt;

            Debug.WriteLine(getURL);

            //Makes a request to the URL and receives the responce
            WebRequest request = WebRequest.Create(getURL);
            WebResponse getResponce = request.GetResponse();

            var dbContext = db.Logs.Create();

            //Assigns the time to the dB
            dbContext.AccessTime = DateTime.Now;

            //Getting the IP of the user
            dbContext.IPAddress = Request.UserHostAddress;

            //What the user searched for 
            dbContext.Request = txt;

            //What the client browser it 
            dbContext.ClientBrowser = Request.UserAgent;

            //Lets save the changes 
            db.Logs.Add(dbContext);
            db.SaveChanges();




            Stream data = request.GetResponse().GetResponseStream();

            //Convert the response to a string 
            string convString = new StreamReader(data).ReadToEnd();

            //lets parse through the JSON ojbect that we received from the endpoint
            var serialize = new System.Web.Script.Serialization.JavaScriptSerializer();
            var jsonObj = serialize.DeserializeObject(convString);

            //Closing stream
            data.Close();
            getResponce.Close();

            //returns JSON obj result 
            return Json(jsonObj, JsonRequestBehavior.AllowGet);


        }
    }
}