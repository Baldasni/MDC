using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace MDC.Controllers
{

    [Authorize]
    public class TestController : Controller
    {

        // GET: Test  
        public ActionResult Identita()
        {
            var roles = ((ClaimsIdentity)User.Identity).Claims
                .Where(c => c.Type == ClaimTypes.Role)
                .Select(c => c.Value);

            ViewBag.Message = "Stai usando un identità con il seguente ruolo: " + string.Join(", ", roles.ToList());

            return View();
            //return Content("We are using Identity");
        }

        // GET: Test  
        [Authorize(Roles = "Admin,Manager")]
        public ActionResult IdentitaAdmin()
        {
            ViewBag.Message = "Stai usando un identità da amministratore";

            return View();
            //return Content("We are using Identity");
        }

        [AllowAnonymous]
        public ActionResult NonIdentita()
        {
            ViewBag.Message = "We are not using Identity";

            return View();
            //return Content("We are not using Identity");
        }
    }
}