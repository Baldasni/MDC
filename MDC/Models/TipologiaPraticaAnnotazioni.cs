using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MDC.Models
{
	[MetadataTypeAttribute(typeof(TipologiaPraticaMetadata))]
	public partial class TipologiaPratica
	{
		//eventuale implementazione della classe
	}

	class TipologiaPraticaMetadata 
    {
        public int IdTipologiaPratica { get; set; }
		[Required]
		public string Descrizione { get; set; }
    }

}