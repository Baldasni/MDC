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
    public class TabellaSocioController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: TabellaSocio
        public ActionResult Index()
        {
            var soci = db.Soci.Include(s => s.ComuneN).Include(s => s.ComuneR);
            return View(soci.ToList());
        }

        // GET: TabellaSocio/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Socio socio = db.Soci.Find(id);
            if (socio == null)
            {
                return HttpNotFound();
            }
            return View(socio);
        }

        // GET: TabellaSocio/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.IdComuneNascita = new SelectList(db.Comuni, "IdComune", "Descrizione");
            ViewBag.IdComuneResidenza = new SelectList(db.Comuni, "IdComune", "Descrizione");
            return View(new Socio());
        }

        // POST: TabellaSocio/Create
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "IdSocio,CodiceFiscale,Nome,Cognome,DataNascita,IdComuneNascita,Sesso,DataIscrizione,Email,Telefono1,Telefono2,IndirizzoResidenza,IdComuneResidenza,Cap")] Socio socio)
        {
            if (ModelState.IsValid)
            {
                socio.IdSocio = Guid.NewGuid();
                db.Soci.Add(socio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdComuneNascita = new SelectList(db.Comuni, "IdComune", "Descrizione", socio.IdComuneNascita);
            ViewBag.IdComuneResidenza = new SelectList(db.Comuni, "IdComune", "Descrizione", socio.IdComuneResidenza);
            return View(socio);
        }

        // GET: TabellaSocio/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Socio socio = db.Soci.Find(id);
            if (socio == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdComuneNascita = new SelectList(db.Comuni, "IdComune", "Descrizione", socio.IdComuneNascita);
            ViewBag.IdComuneResidenza = new SelectList(db.Comuni, "IdComune", "Descrizione", socio.IdComuneResidenza);
            return View(socio);
        }

        // POST: TabellaSocio/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "IdSocio,CodiceFiscale,Nome,Cognome,DataNascita,IdComuneNascita,Sesso,DataIscrizione,Email,Telefono1,Telefono2,IndirizzoResidenza,IdComuneResidenza,Cap")] Socio socio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(socio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdComuneNascita = new SelectList(db.Comuni, "IdComune", "Descrizione", socio.IdComuneNascita);
            ViewBag.IdComuneResidenza = new SelectList(db.Comuni, "IdComune", "Descrizione", socio.IdComuneResidenza);
            return View(socio);
        }

        // GET: TabellaSocio/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Socio socio = db.Soci.Find(id);
            if (socio == null)
            {
                return HttpNotFound();
            }
            return View(socio);
        }

        // POST: TabellaSocio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Socio socio = db.Soci.Find(id);
            db.Soci.Remove(socio);
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
