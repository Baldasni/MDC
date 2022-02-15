using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MDC.Models.ViewModels
{
    public class ListaSociViewModel
    {

        public String MessaggioErrore { get; set; }
        public String MessaggioWorning { get; set; }
        public String MessaggioInfo { get; set; }

        public String Cognome { get; set; }

        public String Nome { get; set; }

        public IEnumerable<Socio> Soci { get; set; }
    }
}