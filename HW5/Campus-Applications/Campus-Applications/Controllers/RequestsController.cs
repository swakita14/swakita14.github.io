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

        /// <summary>
        /// This is the list of all the requests that have been entered into the form
        /// </summary>
        /// <returns>the view in order of the signed date</returns>
        // GET: Requests
        public ActionResult Index()
        {
            return View(db.Requests.ToList().OrderBy(x => x.SignedDate));
        }

        /// <summary>
        /// This is the homepage or the welcome page of the form
        /// </summary>
        /// <returns>view of the homepage</returns>
        public ActionResult Home()
        {
            return View();
        }



        /// <summary>
        /// This is the GET form of the create before the form is submitted
        /// </summary>
        /// <returns>the view of the GET version of the create</returns>
        // GET: Requests/Create
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// This is the POST version of create, which takes all the form inputs and places it in the dB
        /// </summary>
        /// <param name="request">places the all the paramteres into the model</param>
        /// <returns>redirects to the list that has all the list of requests</returns>
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
