using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MDC.Models
{
	[MetadataTypeAttribute(typeof(SportelloMetadata))]
	public partial class Sportello
	{
		//eventuale implementazione della classe
	}

	class SportelloMetadata 
    {
        public int IdSportello { get; set; }
		[Required]
		public string Descrizione { get; set; }
    }

}