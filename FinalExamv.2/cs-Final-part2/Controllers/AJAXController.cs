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
        public JsonResult GetAstronauts(int id)
        {
            string jsonItem = "";
            var mission_crew = db.Crews.Where(x => x.Mission == id).ToList();

            
            if (mission_crew.Count > 0)
            {
                
                jsonItem = JsonConvert.SerializeObject(mission_crew);
            }
                       
            return Json(jsonItem, JsonRequestBehavior.AllowGet);
        }
    }
}