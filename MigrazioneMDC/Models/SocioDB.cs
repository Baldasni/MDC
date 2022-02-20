using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrazioneMDC.Models
{
    class SocioDB
    {
        public System.Guid IdSocio { get; set; }
        public string CodiceFiscale { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Nullable<System.DateTime> DataNascita { get; set; }
        public Nullable<int> IdComuneNascita { get; set; }
        public string Sesso { get; set; }
        public System.DateTime DataIscrizione { get; set; }
        public string Email { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string IndirizzoResidenza { get; set; }
        public Nullable<int> IdComuneResidenza { get; set; }
        public string Cap { get; set; }
    }
}
