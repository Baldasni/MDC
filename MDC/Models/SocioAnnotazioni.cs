using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MDC.Models
{
	[MetadataTypeAttribute(typeof(SocioMetadata))]
	public partial class Socio
	{
		//eventuale implementazione della classe
	}

	class SocioMetadata 
    {
        public System.Guid IdSocio { get; set; }
        [Required]
        [StringLength(16)]
        [RegularExpression( @"/ ^(?:[A - Z][AEIOU][AEIOUX] |[AEIOU]X{2}|[B-DF-HJ-NP-TV-Z]{2}
[A-Z]){ 2} (?:[\dLMNP - V]{ 2} (?:[A - EHLMPR - T](?:[04LQ][1 - 9MNP - V] |[15MR][\dLMNP - V] |[26NS][0 - 8LMNP - U]) |[DHPS][37PT][0L] |[ACELMRT][37PT][01LM] |[AC - EHLMPR - T][26NS][9V])| (?:[02468LNQSU][048LQU] |[13579MPRTV][26NS])B[26NS][9V])(?:[A - MZ][1 - 9MNP - V][\dLMNP - V]{ 2}|[A - M][0L](?:[1 - 9MNP - V][\dLMNP - V] |[0L][1 - 9MNP - V]))[A-Z]$/ i",ErrorMessage = "Codice Fiscale errato")]
        [Display(Name = "Codice Fiscale")]
        public string CodiceFiscale { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data di Nascita")]
        public Nullable<System.DateTime> DataNascita { get; set; }
        [Display(Name = "Comune di Nascita")]
        public Nullable<int> IdComuneNascita { get; set; }
        public string Sesso { get; set; }
        [Display(Name = "Data di Iscrizione")]
        [DataType(DataType.Date)]
        public System.DateTime DataIscrizione { get; set; }
        public string Email { get; set; }
        [Display(Name = "Telefono Principale")]
        public string Telefono1 { get; set; }
        [Display(Name = "Altro Telefono")]
        public string Telefono2 { get; set; }
        [Display(Name = "Indirizzo di Residenza")]
        public string IndirizzoResidenza { get; set; }
        [Display(Name = "Comune di Residenza")]
        public Nullable<int> IdComuneResidenza { get; set; }
        public string Cap { get; set; }
    }

}