using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MDC.Models
{
	[MetadataTypeAttribute(typeof(StatoPraticaMetadata))]
	public partial class StatoPratica
	{
		//eventuale implementazione della classe
	}

	class StatoPraticaMetadata 
    {
        public int IdStatoPratica { get; set; }
		[Required]
		public string Descrizione { get; set; }
    }

}