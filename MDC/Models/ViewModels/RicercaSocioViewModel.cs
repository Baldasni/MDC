using MDC.Models.IdentityModels;
using MDC.Util.CustomValidationAttribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MDC.Models.ViewModels
{
    public class RicercaSocioViewModel
    {
        [OptionalRequired(new string[] { nameof(CodiceFiscale), nameof(Cognome), nameof(Nome) }, MinimumAmount = 1)]
        public String MessaggioErrore { get; set; }
        public String MessaggioWorning{ get; set; }
        public String MessaggioInfo { get; set; }

        //[RegularExpression(@"^(?:[A-Z][AEIOU][AEIOUX]|[AEIOU]X{2}|[B-DF-HJ-NP-TV-Z]{2}[A-Z]){2}(?:[\dLMNP-V]{2}(?:[A-EHLMPR-T](?:[04LQ][1-9MNP-V]|[15MR][\dLMNP-V]|[26NS][0-8LMNP-U])|[DHPS][37PT][0L]|[ACELMRT][37PT][01LM]|[AC-EHLMPR-T][26NS][9V])|(?:[02468LNQSU][048LQU]|[13579MPRTV][26NS])B[26NS][9V])(?:[A-MZ][1-9MNP-V][\dLMNP-V]{2}|[A-M][0L](?:[1-9MNP-V][\dLMNP-V]|[0L][1-9MNP-V]))[A-Z]$/i", ErrorMessage = "Codice Fiscale errato")]

        [StringLength(16, ErrorMessage = "Il codice fiscale deve avere 16 caratteri")]
        [RegularExpression(@"^[a-zA-Z]{6}[0-9]{2}[abcdehlmprstABCDEHLMPRST]{1}[0-9]{2}([a-zA-Z]{1}[0-9]{3})[a-zA-Z]{1}$", ErrorMessage = "Codice Fiscale errato")]
        [Display(Name = "Codice Fiscale")]
        public String CodiceFiscale{ get; set; }

        public String Cognome { get; set; }

        public String Nome { get; set; }
    }
}