using cs_Final_part2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cs_Final_part2.Controllers
{
    public class AJAXController : Controller
    {
        private MissionContext db = new MissionContext();
        // GET: AJAX
        [HttpGet]
        public JsonResult GetAstronauts(int text)
        {
            string jsonItem = "";

            if (text != null)
            {
                /* Initialize our ViewModel */
                var mission_crew = db.Crews.Where(x => x.Mission == text).ToList();

                /* Make sure the given tag has videos before doing anything with the JSON object */
                if (mission_crew.Count > 0)
                {
                    /* Serialize the JSON object */
                    jsonItem = JsonConvert.SerializeObject(mission_crew);
                }
            }

            /* Send the JSON object back -- If there were no videos, this will be an empty string */
            return Json(jsonItem, JsonRequestBehavior.AllowGet);
        }
    }
}