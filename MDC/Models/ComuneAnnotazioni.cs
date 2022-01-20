using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MDC.Models
{
	[MetadataTypeAttribute(typeof(ComuneMetadata))]
	public partial class Comune
	{
		//eventuale implementazione della classe
	}

	class ComuneMetadata 
    {
        public int IdComune { get; set; }
        [Required]
        [Display(Name = "Provincia")]
        public int IdProvincia { get; set; }
        [Required]
        public string Descrizione { get; set; }
    }

}