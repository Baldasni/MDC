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
    public class TabellaComuneController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: TabellaComune
        public ActionResult GetComuni()
        {
            var comuni = db.Comuni.Include(c => c.Provincia);
            //return View(comuni.ToList());

            var model = (from comune in comuni.AsEnumerable()

                         select new 
                         {
                             IdComune = comune.IdComune,
                             IdProvincia = comune.IdProvincia,
                             Provincia = comune.Provincia.Descrizione,
                             Descrizione = comune.Descrizione
                         }
                         //new Comune()
                         //{
                         //    IdComune = comune.IdComune,
                         //    IdProvincia = comune.IdProvincia,
                         //    Descrizione = comune.Descrizione
                         //}
                         );


            return Json(model, JsonRequestBehavior.AllowGet);
        }

        // GET: TabellaComune
        public ActionResult Index()
        {
            var comuni = db.Comuni.Include(c => c.Provincia);
            return View(comuni.ToList());
        }

        // GET: TabellaComune/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comune comune = db.Comuni.Find(id);
            if (comune == null)
            {
                return HttpNotFound();
            }
            return View(comune);
        }

        // GET: TabellaComune/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.IdProvincia = new SelectList(db.Province, "IdProvincia", "Sigla");
            return View(new Comune());
        }

        // POST: TabellaComune/Create
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "IdComune,IdProvincia,Descrizione")] Comune comune)
        {
            if (ModelState.IsValid)
            {
                db.Comuni.Add(comune);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdProvincia = new SelectList(db.Province, "IdProvincia", "Sigla", comune.IdProvincia);
            return View(comune);
        }

        // GET: TabellaComune/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comune comune = db.Comuni.Find(id);
            if (comune == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdProvincia = new SelectList(db.Province, "IdProvincia", "Sigla", comune.IdProvincia);
            return View(comune);
        }

        // POST: TabellaComune/Edit/5
        // Per la protezione da attacchi di overposting, abilitare le proprietà a cui eseguire il binding. 
        // Per altri dettagli, vedere https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "IdComune,IdProvincia,Descrizione")] Comune comune)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comune).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdProvincia = new SelectList(db.Province, "IdProvincia", "Sigla", comune.IdProvincia);
            return View(comune);
        }

        // GET: TabellaComune/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comune comune = db.Comuni.Find(id);
            if (comune == null)
            {
                return HttpNotFound();
            }
            return View(comune);
        }

        // POST: TabellaComune/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteConfirmed(int id)
        {
            Comune comune = db.Comuni.Find(id);
            db.Comuni.Remove(comune);
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
