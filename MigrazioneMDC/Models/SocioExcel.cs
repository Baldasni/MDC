using Npoi.Mapper.Attributes;

namespace MigrazioneMDC.Models
{
    class SocioExcel
    {
        [Column("* Nome")]
        public string Nome { get; set; }
        [Column("* Cognome")]
        public string Cognome { get; set; }
        [Column("Email")]
        public string Email { get; set; }
        [Column("Telefono")]
        public string Telefono1 { get; set; }
        [Column("Altro Telefono")]
        public string Telefono2 { get; set; }
        [Column("* Indirizzo residenza (via e numero)")]
        public string IndirizzoResidenza { get; set; }
        [Column("* Comune residenza")]
        public string ComuneResidenza { get; set; }
        [Column("* Provincia residenza")]
        public string ProvinciaResidenza { get; set; }
        [Column("* C.A.P. residenza")]
        public string CAPResidenza { get; set; }
        [Column("* Regione")]
        public string Regione { get; set; }
        [Column("Sesso")]
        public string Sesso { get; set; }
        [Column("Tessera cartacea MDC")]
        public string TesseraCartacea { get; set; }
        [Column("* Codice fiscale")]
        public string CodiceFiscale { get; set; }
        [Column("Comune di nascita")]
        public string ComuneNascita { get; set; }
        [Column("Data di nascita")]
        public string DataNascita { get; set; }
        [Column("ANNO ")]
        public string Anno { get; set; }
        [Column("data")]
        public string DataIscrizione { get; set; }
        [Column("NOTA")]
        public string Nota { get; set; }
    }
}
