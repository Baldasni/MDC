﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MDC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Comune> Comuni { get; set; }
        public virtual DbSet<Consulenza> Consulenze { get; set; }
        public virtual DbSet<Pratica> Pratiche { get; set; }
        public virtual DbSet<Provincia> Province { get; set; }
        public virtual DbSet<Socio> Soci { get; set; }
        public virtual DbSet<Sportello> Sportelli { get; set; }
        public virtual DbSet<StatoPratica> StatiPratica { get; set; }
        public virtual DbSet<TipologiaContatto> TipologieContatto { get; set; }
        public virtual DbSet<TipologiaPratica> TipologiePratica { get; set; }
        public virtual DbSet<Rinnovo> Rinnovi { get; set; }
    }
}
