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
    public class TabellaRinnovoController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: TabellaRinnovo
        public ActionResult Index()
        {
            var rinnovi = db.Rinnovi.Include(r => r.Socio);
            return View(rinnovi.ToList());
        }

        // GET: TabellaRinnovo/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rinnovo rinnovo = db.Rinnovi.Find(id);
            if (rinnovo == null)
            {
                return HttpNotFound();
            }
            return View(rinnovo);
        }

        // GET: TabellaRinnovo/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.IdSocio = new SelectList(db.Soci, "IdSocio", "CodiceFiscale");
            return View(new Rinnovo());
        }

        // POST: TabellaRinnovo/Create
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "IdRinnovo,IdSocio,Data,Anno1,Anno2,Quota_iscrizione")] Rinnovo rinnovo)
        {
            if (ModelState.IsValid)
            {
                rinnovo.IdRinnovo = Guid.NewGuid();
                db.Rinnovi.Add(rinnovo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdSocio = new SelectList(db.Soci, "IdSocio", "CodiceFiscale", rinnovo.IdSocio);
            return View(rinnovo);
        }

        // GET: TabellaRinnovo/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rinnovo rinnovo = db.Rinnovi.Find(id);
            if (rinnovo == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdSocio = new SelectList(db.Soci, "IdSocio", "CodiceFiscale", rinnovo.IdSocio);
            return View(rinnovo);
        }

        // POST: TabellaRinnovo/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "IdRinnovo,IdSocio,Data,Anno1,Anno2,Quota_iscrizione")] Rinnovo rinnovo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rinnovo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdSocio = new SelectList(db.Soci, "IdSocio", "CodiceFiscale", rinnovo.IdSocio);
            return View(rinnovo);
        }

        // GET: TabellaRinnovo/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rinnovo rinnovo = db.Rinnovi.Find(id);
            if (rinnovo == null)
            {
                return HttpNotFound();
            }
            return View(rinnovo);
        }

        // POST: TabellaRinnovo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Rinnovo rinnovo = db.Rinnovi.Find(id);
            db.Rinnovi.Remove(rinnovo);
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
