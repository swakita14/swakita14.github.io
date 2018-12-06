using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cs_Final_part2.Models;

namespace cs_Final_part2.Controllers
{
    public class AstronautsController : Controller
    {
        private MissionContext db = new MissionContext();

        // GET: Astronauts
        public ActionResult Index()
        {
            var astronauts = db.Astronauts.Include(a => a.Country);
            return View(astronauts.ToList());
        }

        // GET: Astronauts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Astronaut astronaut = db.Astronauts.Find(id);
            if (astronaut == null)
            {
                return HttpNotFound();
            }
            return View(astronaut);
        }

        // GET: Astronauts/Create
        public ActionResult Create()
        {
            ViewBag.Nationality = new SelectList(db.Countries, "CountryID", "CountryName");
            return View();
        }

        // POST: Astronauts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AstronautID,Name,Birthday,Nationality")] Astronaut astronaut)
        {
            if (ModelState.IsValid)
            {
                db.Astronauts.Add(astronaut);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Nationality = new SelectList(db.Countries, "CountryID", "CountryName", astronaut.Nationality);
            return View(astronaut);
        }

        // GET: Astronauts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Astronaut astronaut = db.Astronauts.Find(id);
            if (astronaut == null)
            {
                return HttpNotFound();
            }
            ViewBag.Nationality = new SelectList(db.Countries, "CountryID", "CountryName", astronaut.Nationality);
            return View(astronaut);
        }

        // POST: Astronauts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AstronautID,Name,Birthday,Nationality")] Astronaut astronaut)
        {
            if (ModelState.IsValid)
            {
                db.Entry(astronaut).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Nationality = new SelectList(db.Countries, "CountryID", "CountryName", astronaut.Nationality);
            return View(astronaut);
        }

        // GET: Astronauts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Astronaut astronaut = db.Astronauts.Find(id);
            if (astronaut == null)
            {
                return HttpNotFound();
            }
            return View(astronaut);
        }

        // POST: Astronauts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Astronaut astronaut = db.Astronauts.Find(id);
            db.Astronauts.Remove(astronaut);
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
