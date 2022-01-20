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
    public class TabellaConsulenzaController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: TabellaConsulenza
        public ActionResult Index()
        {
            var consulenze = db.Consulenze.Include(c => c.Comune).Include(c => c.Socio).Include(c => c.TipologiaContatto).Include(c => c.TipologiaPratica);
            return View(consulenze.ToList());
        }

        // GET: TabellaConsulenza/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consulenza consulenza = db.Consulenze.Find(id);
            if (consulenza == null)
            {
                return HttpNotFound();
            }
            return View(consulenza);
        }

        // GET: TabellaConsulenza/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.IdComune = new SelectList(db.Comuni, "IdComune", "Descrizione");
            ViewBag.IdSocio = new SelectList(db.Soci, "IdSocio", "CodiceFiscale");
            ViewBag.IdTipologiaContatto = new SelectList(db.TipologieContatto, "IdTipologiaContatto", "Descrizione");
            ViewBag.IdTipologiaPratica = new SelectList(db.TipologiePratica, "IdTipologiaPratica", "Descrizione");
            return View(new Consulenza());
        }

        // POST: TabellaConsulenza/Create
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "IdConsulenza,IdSocio,DataConsulenza,IdTipologiaPratica,DescrizioneConsulenza,IdTipologiaContatto,Nominativo,Email,IdComune")] Consulenza consulenza)
        {
            if (ModelState.IsValid)
            {
                consulenza.IdConsulenza = Guid.NewGuid();
                db.Consulenze.Add(consulenza);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdComune = new SelectList(db.Comuni, "IdComune", "Descrizione", consulenza.IdComune);
            ViewBag.IdSocio = new SelectList(db.Soci, "IdSocio", "CodiceFiscale", consulenza.IdSocio);
            ViewBag.IdTipologiaContatto = new SelectList(db.TipologieContatto, "IdTipologiaContatto", "Descrizione", consulenza.IdTipologiaContatto);
            ViewBag.IdTipologiaPratica = new SelectList(db.TipologiePratica, "IdTipologiaPratica", "Descrizione", consulenza.IdTipologiaPratica);
            return View(consulenza);
        }

        // GET: TabellaConsulenza/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consulenza consulenza = db.Consulenze.Find(id);
            if (consulenza == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdComune = new SelectList(db.Comuni, "IdComune", "Descrizione", consulenza.IdComune);
            ViewBag.IdSocio = new SelectList(db.Soci, "IdSocio", "CodiceFiscale", consulenza.IdSocio);
            ViewBag.IdTipologiaContatto = new SelectList(db.TipologieContatto, "IdTipologiaContatto", "Descrizione", consulenza.IdTipologiaContatto);
            ViewBag.IdTipologiaPratica = new SelectList(db.TipologiePratica, "IdTipologiaPratica", "Descrizione", consulenza.IdTipologiaPratica);
            return View(consulenza);
        }

        // POST: TabellaConsulenza/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "IdConsulenza,IdSocio,DataConsulenza,IdTipologiaPratica,DescrizioneConsulenza,IdTipologiaContatto,Nominativo,Email,IdComune")] Consulenza consulenza)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consulenza).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdComune = new SelectList(db.Comuni, "IdComune", "Descrizione", consulenza.IdComune);
            ViewBag.IdSocio = new SelectList(db.Soci, "IdSocio", "CodiceFiscale", consulenza.IdSocio);
            ViewBag.IdTipologiaContatto = new SelectList(db.TipologieContatto, "IdTipologiaContatto", "Descrizione", consulenza.IdTipologiaContatto);
            ViewBag.IdTipologiaPratica = new SelectList(db.TipologiePratica, "IdTipologiaPratica", "Descrizione", consulenza.IdTipologiaPratica);
            return View(consulenza);
        }

        // GET: TabellaConsulenza/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Consulenza consulenza = db.Consulenze.Find(id);
            if (consulenza == null)
            {
                return HttpNotFound();
            }
            return View(consulenza);
        }

        // POST: TabellaConsulenza/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Consulenza consulenza = db.Consulenze.Find(id);
            db.Consulenze.Remove(consulenza);
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
