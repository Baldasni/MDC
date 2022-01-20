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
    public class TabellaTipologiaPraticaController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: TabellaTipologiaPratica
        public ActionResult Index()
        {
            return View(db.TipologiePratica.ToList());
        }

        // GET: TabellaTipologiaPratica/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipologiaPratica tipologiaPratica = db.TipologiePratica.Find(id);
            if (tipologiaPratica == null)
            {
                return HttpNotFound();
            }
            return View(tipologiaPratica);
        }

        // GET: TabellaTipologiaPratica/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View(new TipologiaPratica());
        }

        // POST: TabellaTipologiaPratica/Create
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "IdTipologiaPratica,Descrizione")] TipologiaPratica tipologiaPratica)
        {
            if (ModelState.IsValid)
            {
                db.TipologiePratica.Add(tipologiaPratica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipologiaPratica);
        }

        // GET: TabellaTipologiaPratica/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipologiaPratica tipologiaPratica = db.TipologiePratica.Find(id);
            if (tipologiaPratica == null)
            {
                return HttpNotFound();
            }
            return View(tipologiaPratica);
        }

        // POST: TabellaTipologiaPratica/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "IdTipologiaPratica,Descrizione")] TipologiaPratica tipologiaPratica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipologiaPratica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipologiaPratica);
        }

        // GET: TabellaTipologiaPratica/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipologiaPratica tipologiaPratica = db.TipologiePratica.Find(id);
            if (tipologiaPratica == null)
            {
                return HttpNotFound();
            }
            return View(tipologiaPratica);
        }

        // POST: TabellaTipologiaPratica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            TipologiaPratica tipologiaPratica = db.TipologiePratica.Find(id);
            db.TipologiePratica.Remove(tipologiaPratica);
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
