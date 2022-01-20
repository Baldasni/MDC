using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MDC.Models
{
	[MetadataTypeAttribute(typeof(ProvinciaMetadata))]
	public partial class Provincia
	{
		//eventuale implementazione della classe
	}

	class ProvinciaMetadata 
    {
        public int IdProvincia { get; set; }
        public string Sigla { get; set; }
        public string Descrizione { get; set; }
        public string Regione { get; set; }
    }

}