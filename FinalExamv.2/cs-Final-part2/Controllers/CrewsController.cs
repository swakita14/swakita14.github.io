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
    public class CrewsController : Controller
    {
        private MissionContext db = new MissionContext();

        // GET: Crews
        public ActionResult Index()
        {
            var crews = db.Crews.Include(c => c.Astronaut1).Include(c => c.Mission1);
            return View(crews.ToList());
        }

        // GET: Crews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crew crew = db.Crews.Find(id);
            if (crew == null)
            {
                return HttpNotFound();
            }
            return View(crew);
        }

        // GET: Crews/Create
        public ActionResult Create()
        {
            ViewBag.Astronaut = new SelectList(db.Astronauts, "AstronautID", "Name");
            ViewBag.Mission = new SelectList(db.Missions, "MissionID", "Designation");
            return View();
        }

        // POST: Crews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CrewID,Astronaut,Mission,Position")] Crew crew)
        {
            if (ModelState.IsValid)
            {
                db.Crews.Add(crew);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Astronaut = new SelectList(db.Astronauts, "AstronautID", "Name", crew.Astronaut);
            ViewBag.Mission = new SelectList(db.Missions, "MissionID", "Designation", crew.Mission);
            return View(crew);
        }

        // GET: Crews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crew crew = db.Crews.Find(id);
            if (crew == null)
            {
                return HttpNotFound();
            }
            ViewBag.Astronaut = new SelectList(db.Astronauts, "AstronautID", "Name", crew.Astronaut);
            ViewBag.Mission = new SelectList(db.Missions, "MissionID", "Designation", crew.Mission);
            return View(crew);
        }

        // POST: Crews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CrewID,Astronaut,Mission,Position")] Crew crew)
        {
            if (ModelState.IsValid)
            {
                db.Entry(crew).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Astronaut = new SelectList(db.Astronauts, "AstronautID", "Name", crew.Astronaut);
            ViewBag.Mission = new SelectList(db.Missions, "MissionID", "Designation", crew.Mission);
            return View(crew);
        }

        // GET: Crews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crew crew = db.Crews.Find(id);
            if (crew == null)
            {
                return HttpNotFound();
            }
            return View(crew);
        }

        // POST: Crews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Crew crew = db.Crews.Find(id);
            db.Crews.Remove(crew);
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
