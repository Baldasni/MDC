using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MDC.Controllers
{
    public class GestioneReportController : Controller
    {
        // GET: GestioneReport/Riepilogo
        public ActionResult Riepilogo()
        {
            return View();
        }
        // GET: GestioneReport/ReportAnno
        public ActionResult ReportAnno()
        {
            return View();
        }
        // GET: GestioneReport/ReportSportello
        public ActionResult ReportSportello()
        {
            return View();
        }
    }
}