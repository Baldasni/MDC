using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MDC.Models;

namespace MDC.Controllers
{
    [Authorize(Roles = "Admin,Manager")]
    public class TabellaSportelloController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: TabellaSportello
        public ActionResult Index()
        {
            return View(db.Sportelli.ToList());
        }

        // GET: TabellaSportello/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sportello sportello = db.Sportelli.Find(id);
            if (sportello == null)
            {
                return HttpNotFound();
            }
            return View(sportello);
        }

        // GET: TabellaSportello/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View(new Sportello());
        }

        // POST: TabellaSportello/Create
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "IdSportello,Descrizione")] Sportello sportello)
        {
            if (ModelState.IsValid)
            {
                db.Sportelli.Add(sportello);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sportello);
        }

        // GET: TabellaSportello/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sportello sportello = db.Sportelli.Find(id);
            if (sportello == null)
            {
                return HttpNotFound();
            }
            return View(sportello);
        }

        // POST: TabellaSportello/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "IdSportello,Descrizione")] Sportello sportello)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sportello).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sportello);
        }

        // GET: TabellaSportello/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sportello sportello = db.Sportelli.Find(id);
            if (sportello == null)
            {
                return HttpNotFound();
            }
            return View(sportello);
        }

        // POST: TabellaSportello/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            Sportello sportello = db.Sportelli.Find(id);
            db.Sportelli.Remove(sportello);
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
