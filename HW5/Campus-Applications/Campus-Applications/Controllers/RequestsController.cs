﻿using System;
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
            return View(db.Requests);
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
                db.Requests.Add(request);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(request);
        }

        // GET: Requests1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = db.Requests.Find(id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        // POST: Requests1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Request request = db.Requests.Find(id);
            db.Requests.Remove(request);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }

  
}
