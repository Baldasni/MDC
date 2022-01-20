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
    public class TabellaTipologiaContattoController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: TabellaTipologiaContatto
        public ActionResult Index()
        {
            return View(db.TipologieContatto.ToList());
        }

        // GET: TabellaTipologiaContatto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipologiaContatto tipologiaContatto = db.TipologieContatto.Find(id);
            if (tipologiaContatto == null)
            {
                return HttpNotFound();
            }
            return View(tipologiaContatto);
        }

        // GET: TabellaTipologiaContatto/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View(new TipologiaContatto());
        }

        // POST: TabellaTipologiaContatto/Create
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "IdTipologiaContatto,Descrizione")] TipologiaContatto tipologiaContatto)
        {
            if (ModelState.IsValid)
            {
                db.TipologieContatto.Add(tipologiaContatto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipologiaContatto);
        }

        // GET: TabellaTipologiaContatto/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipologiaContatto tipologiaContatto = db.TipologieContatto.Find(id);
            if (tipologiaContatto == null)
            {
                return HttpNotFound();
            }
            return View(tipologiaContatto);
        }

        // POST: TabellaTipologiaContatto/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "IdTipologiaContatto,Descrizione")] TipologiaContatto tipologiaContatto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipologiaContatto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipologiaContatto);
        }

        // GET: TabellaTipologiaContatto/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipologiaContatto tipologiaContatto = db.TipologieContatto.Find(id);
            if (tipologiaContatto == null)
            {
                return HttpNotFound();
            }
            return View(tipologiaContatto);
        }

        // POST: TabellaTipologiaContatto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            TipologiaContatto tipologiaContatto = db.TipologieContatto.Find(id);
            db.TipologieContatto.Remove(tipologiaContatto);
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
