using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MDC.Models
{
	[MetadataTypeAttribute(typeof(RinnovoMetadata))]
	public partial class Rinnovo
	{
		//eventuale implementazione della classe
	}

	class RinnovoMetadata 
    {
        public System.Guid IdRinnovo { get; set; }
        [Required]
        [Display(Name = "Socio")]
        public System.Guid IdSocio { get; set; }
        [Required]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Data del Rinnovo")]
        [DataType(DataType.Date)]
        public System.DateTime Data { get; set; }
        [Required]
        [Range(typeof(int), "1970", "2100", ErrorMessage = "Inserire un anno valido (maggiore di {0} e minore di {1}")]
        [Display(Name = "Primo Anno")] 
        public Nullable<int> Anno1 { get; set; }
        [Required]
        [Range(typeof(int), "1970", "2100", ErrorMessage = "Inserire un anno valido (maggiore di {0} e minore di {1}")]
        [Display(Name = "Secondo Anno")]
        public Nullable<int> Anno2 { get; set; }
        //[DataType(DataType.Currency)]
        //[Display(Name = "Quota di Iscrizione")]
        [Required]
        [Display(Name = "Quota di Iscrizione"),
         DataType(DataType.Currency),
         DisplayFormat(NullDisplayText = "-",
                       ApplyFormatInEditMode = false,
                       DataFormatString = "{0:C}")]
        [Range(typeof(float), "0", "1000", ErrorMessage = "Valore non ammesso")]

        public float Quota_iscrizione { get; set; }
    }

}