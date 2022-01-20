using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MDC.Models
{
	[MetadataTypeAttribute(typeof(TipologiaContrattoMetadata))]
	public partial class TipologiaContratto
	{
		//eventuale implementazione della classe
	}

	class TipologiaContrattoMetadata 
    {
        public int IdTipologiaContatto { get; set; }
		[Required]
		public string Descrizione { get; set; }
    }

}