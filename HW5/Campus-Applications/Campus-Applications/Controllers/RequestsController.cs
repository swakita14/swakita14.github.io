using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Campus_Applications.DAL;
using Campus_Applications.Models;

namespace Campus_Applications.Controllers
{
    public class RequestsController : Controller
    {
        private RequestdbContext db = new RequestdbContext();

        // GET: Requests
        public ActionResult Index()
        {
            return View(db.Requests.ToList().OrderBy(x => x.SignedDate));
        }

        public ActionResult Home()
        {
            return View();
        }




        // GET: Requests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Requests/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,PhoneNumber,ApartmentName,Explanation,UnitNumber,CallMe,SignedDate")] Request request)
        {
            if (ModelState.IsValid)
            {
                db.Requests.Add(request); //stages it
                db.SaveChanges(); //Fully commits to database
                return RedirectToAction("Index");
            }

            return View(request);
        }


    }

  
}
