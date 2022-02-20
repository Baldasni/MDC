using MDC.Models;
using MDC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MDC.Controllers
{
    [Authorize]
    public class GestioneSociController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: GestioneSoci/Ricerca
        public ActionResult Ricerca()
        {
            RicercaSocioViewModel rsVM= new RicercaSocioViewModel();
            return View(rsVM);
        }
        // GET: GestioneSoci/Ricerca
        [HttpPost]
        public ActionResult Ricerca(RicercaSocioViewModel rsVM)
        {
            if (ModelState.IsValid)
            {
                if (!String.IsNullOrEmpty(rsVM.CodiceFiscale))
                {
                    string guid = CercaGuidFromCodFisc(rsVM.CodiceFiscale);
                    if (String.IsNullOrEmpty(guid))
                    {
                        ModelState.AddModelError("CodiceFiscale", "Codice Fiscale non trovato in archivio");
                        return View(rsVM);
                    }
                    return RedirectToAction("VisualizzaSocio", guid);
                }
                else
                {
                    if (!string.IsNullOrEmpty(rsVM.Cognome) && !String.IsNullOrEmpty(rsVM.Nome))
                        return RedirectToAction("ListaSoci", "GestioneSoci", new { cognome = rsVM.Cognome, nome = rsVM.Nome });
                    else if (!string.IsNullOrEmpty(rsVM.Cognome))
                        return RedirectToAction("ListaSoci", "GestioneSoci", new { cognome = rsVM.Cognome });
                    else if (!string.IsNullOrEmpty(rsVM.Nome))
                        return RedirectToAction("ListaSoci", "GestioneSoci", new { nome = rsVM.Nome });
                    else
                    {
                        //ModelState.AddModelError("", "Inserire almento un valore");
                        rsVM.MessaggioErrore = "Inserire almento un valore";
                    }
                }
            }
            return View(rsVM);
        }

        public ActionResult ListaSoci(string cognome, string nome)
        {
            ListaSociViewModel lsVM = new ListaSociViewModel();
            lsVM.Cognome = cognome;
            lsVM.Nome = nome;

            if (String.IsNullOrEmpty(cognome) && string.IsNullOrEmpty(nome))
            {
                lsVM.Soci = new List<Socio>();
            }
            else
            {
                IQueryable<Socio> soci = null;
                if (!string.IsNullOrEmpty(cognome))
                    soci = db.Soci.Where(s => s.Cognome.Contains(cognome));

                if (!string.IsNullOrEmpty(nome))
                    if (soci == null)
                        soci = db.Soci.Where(s => s.Nome.Contains(nome));
                    else
                        soci = soci.Where(s => s.Nome.Contains(nome));

                lsVM.Soci = soci.ToList<Socio>();
            }
            return View(lsVM);
        }
        private string CercaGuidFromCodFisc(string codFisc)
        {
            var socio = db.Soci.Where(s => s.CodiceFiscale == codFisc);
            //return View(comuni.ToList());

            if (socio.FirstOrDefault() == null) return null;

            return socio.FirstOrDefault().IdSocio.ToString();
        }

        // GET: GestioneSoci/Inserimento
        public ActionResult Inserimento()
        {
            return View();
        }
        // GET: GestioneSoci/Rinnovo
        public ActionResult Rinnovo()
        {
            return View();
        }
    }
}