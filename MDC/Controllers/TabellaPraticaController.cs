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
    public class TabellaPraticaController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: TabellaPratica
        public ActionResult Index()
        {
            var pratiche = db.Pratiche.Include(p => p.Socio).Include(p => p.Sportello).Include(p => p.StatoPratica).Include(p => p.TipologiaPratica);
            return View(pratiche.ToList());
        }

        // GET: TabellaPratica/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pratica pratica = db.Pratiche.Find(id);
            if (pratica == null)
            {
                return HttpNotFound();
            }
            return View(pratica);
        }

        // GET: TabellaPratica/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.IdSocio = new SelectList(db.Soci, "IdSocio", "CodiceFiscale");
            ViewBag.IdSportello = new SelectList(db.Sportelli, "IdSportello", "Descrizione");
            ViewBag.IdStatoPratica = new SelectList(db.StatiPratica, "IdStatoPratica", "Descrizione");
            ViewBag.IdTipologiaPratica = new SelectList(db.TipologiePratica, "IdTipologiaPratica", "Descrizione");
            return View(new Pratica());
        }

        // POST: TabellaPratica/Create
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "IdPratica,IdSocio,IdSportello,DataPratica,IdTipologiaPratica,DescrizionePratica,IdStatoPratica,DescrizioneRiscontro")] Pratica pratica)
        {
            if (ModelState.IsValid)
            {
                pratica.IdPratica = Guid.NewGuid();
                db.Pratiche.Add(pratica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdSocio = new SelectList(db.Soci, "IdSocio", "CodiceFiscale", pratica.IdSocio);
            ViewBag.IdSportello = new SelectList(db.Sportelli, "IdSportello", "Descrizione", pratica.IdSportello);
            ViewBag.IdStatoPratica = new SelectList(db.StatiPratica, "IdStatoPratica", "Descrizione", pratica.IdStatoPratica);
            ViewBag.IdTipologiaPratica = new SelectList(db.TipologiePratica, "IdTipologiaPratica", "Descrizione", pratica.IdTipologiaPratica);
            return View(pratica);
        }

        // GET: TabellaPratica/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pratica pratica = db.Pratiche.Find(id);
            if (pratica == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdSocio = new SelectList(db.Soci, "IdSocio", "CodiceFiscale", pratica.IdSocio);
            ViewBag.IdSportello = new SelectList(db.Sportelli, "IdSportello", "Descrizione", pratica.IdSportello);
            ViewBag.IdStatoPratica = new SelectList(db.StatiPratica, "IdStatoPratica", "Descrizione", pratica.IdStatoPratica);
            ViewBag.IdTipologiaPratica = new SelectList(db.TipologiePratica, "IdTipologiaPratica", "Descrizione", pratica.IdTipologiaPratica);
            return View(pratica);
        }

        // POST: TabellaPratica/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "IdPratica,IdSocio,IdSportello,DataPratica,IdTipologiaPratica,DescrizionePratica,IdStatoPratica,DescrizioneRiscontro")] Pratica pratica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pratica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdSocio = new SelectList(db.Soci, "IdSocio", "CodiceFiscale", pratica.IdSocio);
            ViewBag.IdSportello = new SelectList(db.Sportelli, "IdSportello", "Descrizione", pratica.IdSportello);
            ViewBag.IdStatoPratica = new SelectList(db.StatiPratica, "IdStatoPratica", "Descrizione", pratica.IdStatoPratica);
            ViewBag.IdTipologiaPratica = new SelectList(db.TipologiePratica, "IdTipologiaPratica", "Descrizione", pratica.IdTipologiaPratica);
            return View(pratica);
        }

        // GET: TabellaPratica/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pratica pratica = db.Pratiche.Find(id);
            if (pratica == null)
            {
                return HttpNotFound();
            }
            return View(pratica);
        }

        // POST: TabellaPratica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Pratica pratica = db.Pratiche.Find(id);
            db.Pratiche.Remove(pratica);
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
