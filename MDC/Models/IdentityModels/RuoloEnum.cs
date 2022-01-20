using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MDC.Models.IdentityModels
{
    //Una volta registrato la persona diventa utente ma non può vedere nulla
    //Il Coordinatore o l'Amministratore deve autorizzare l'utente a impiegato.

    public enum RuoloEnum
    {
        [Display(Name = "Amministratore")]
        Admin,
        [Display(Name = "Coordinatore")]
        Manager,
        [Display(Name = "Impiegato")]
        Employee,
        [Display(Name = "Utente")] 
        Customer
    }
        //[Display(Name = "Utenti")]
        //CustomerManager,

}