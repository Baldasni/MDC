using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MDC.Models
{
    [MetadataTypeAttribute(typeof(RegioneMetadata))]
    public partial class Regione
    {
    }

    class RegioneMetadata
    {
        public int IdRegione { get; set; }
        public string Descrizione { get; set; }
    }
}