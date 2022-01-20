using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MDC.Controllers
{
    public class GestionePraticheController : Controller
    {
        //GET: GestionePratiche/Ricerca
        public ActionResult Ricerca()
        {
            return View();
        }
        //GET: GestionePratiche/Inserimento
        public ActionResult Inserimento()
        {
            return View();
        }
    }

}