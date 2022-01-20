using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MDC.Models
{
	[MetadataTypeAttribute(typeof(PraticaMetadata))]
	public partial class Pratica
	{
		//eventuale implementazione della classe
	}

	class PraticaMetadata 
    {
        public System.Guid IdPratica { get; set; }
        [Display(Name = "Sportello")]
        public int IdSportello { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data della Pratica")]
        public System.DateTime DataPratica { get; set; }
        [Required]
        [Display(Name = "Tipo Pratica")]
        public int IdTipologiaPratica { get; set; }
        [Required]
        [Display(Name = "Descrizione della Pratica")]
        public string DescrizionePratica { get; set; }
        [Required]
        [Display(Name = "Stato della Pratica")]
        public int IdStatoPratica { get; set; }
        [Display(Name = "Descrizione Riscontro")]
        public string DescrizioneRiscontro { get; set; }
    }

}