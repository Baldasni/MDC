using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MDC.Models
{
	[MetadataTypeAttribute(typeof(ConsulenzaMetadata))]
	public partial class Consulenza
	{
		//eventuale implementazione della classe
	}

	class ConsulenzaMetadata 
    {
		public System.Guid IdConsulenza { get; set; }
        [Display(Name = "Socio")]
        public Nullable<System.Guid> IdSocio { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data della Consulenza")]
        public System.DateTime DataConsulenza { get; set; }
        [Required]
        [Display(Name = "Tipo Pratica")]
        public int IdTipologiaPratica { get; set; }
        [Required]
        [Display(Name = "Descrizione della Consulenza")]
        public string DescrizioneConsulenza { get; set; }
        [Display(Name = "Tipo Contatto")]
        public Nullable<int> IdTipologiaContatto { get; set; }
        [Required]
        public string Nominativo { get; set; }
        public string Email { get; set; }
        [Display(Name = "Comune")]
        public Nullable<int> IdComune { get; set; }
    }

}