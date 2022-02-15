using MDC.Models;
using MDC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MDC.Controllers
{
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
            if (!String.IsNullOrEmpty(rsVM.CodiceFiscale))
            {
                string guid = CercaGuidFromCodFisc(rsVM.CodiceFiscale);
                RedirectToAction("VisualizzaSocio", guid);
            }
            else
            {
                if (!string.IsNullOrEmpty(rsVM.Cognome) && !String.IsNullOrEmpty(rsVM.Nome))
                    RedirectToAction("ListaSoci", "GestioneSoci", new { cognome = rsVM.Cognome, nome = rsVM.Nome });
                else if (!string.IsNullOrEmpty(rsVM.Cognome))
                    RedirectToAction("ListaSoci", "GestioneSoci", new { cognome = rsVM.Cognome });
                else if (!string.IsNullOrEmpty(rsVM.Nome))
                    RedirectToAction("ListaSoci", "GestioneSoci", new { nome = rsVM.Nome });
                else
                    rsVM.MessaggioErrore = "Inserire almento un valore";
            }
            return View(rsVM);
        }

        public ActionResult ListaSoci(string cognome, string nome)
        {
            ListaSociViewModel lsVM = new ListaSociViewModel();
            lsVM.Cognome = cognome;
            lsVM.Nome = nome;

            lsVM.Soci = db.Soci.Where(s => s.Cognome == cognome && s.Nome == nome);

            return View(lsVM);
        }
        private string CercaGuidFromCodFisc(string codFisc)
        {
            var socio = db.Soci.Where(s => s.CodiceFiscale == codFisc);
            //return View(comuni.ToList());

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