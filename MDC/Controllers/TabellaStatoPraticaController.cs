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
    public class TabellaStatoPraticaController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: TabellaStatoPratica
        public ActionResult Index()
        {
            return View(db.StatiPratica.ToList());
        }

        // GET: TabellaStatoPratica/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatoPratica statoPratica = db.StatiPratica.Find(id);
            if (statoPratica == null)
            {
                return HttpNotFound();
            }
            return View(statoPratica);
        }

        // GET: TabellaStatoPratica/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View(new StatoPratica());
        }

        // POST: TabellaStatoPratica/Create
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "IdStatoPratica,Descrizione")] StatoPratica statoPratica)
        {
            if (ModelState.IsValid)
            {
                db.StatiPratica.Add(statoPratica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(statoPratica);
        }

        // GET: TabellaStatoPratica/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatoPratica statoPratica = db.StatiPratica.Find(id);
            if (statoPratica == null)
            {
                return HttpNotFound();
            }
            return View(statoPratica);
        }

        // POST: TabellaStatoPratica/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "IdStatoPratica,Descrizione")] StatoPratica statoPratica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(statoPratica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(statoPratica);
        }

        // GET: TabellaStatoPratica/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StatoPratica statoPratica = db.StatiPratica.Find(id);
            if (statoPratica == null)
            {
                return HttpNotFound();
            }
            return View(statoPratica);
        }

        // POST: TabellaStatoPratica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            StatoPratica statoPratica = db.StatiPratica.Find(id);
            db.StatiPratica.Remove(statoPratica);
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
