﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibreriaComun.Modelos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBLPFEntities : DbContext
    {
        public DBLPFEntities()
            : base("name=DBLPFEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Atributo> Atributo { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Estacion_Trabajo> Estacion_Trabajo { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Estado_Estacion_Trabajo> Estado_Estacion_Trabajo { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
        public virtual DbSet<Figura> Figura { get; set; }
        public virtual DbSet<Historico> Historico { get; set; }
        public virtual DbSet<Historico_Estacion_Trabajo> Historico_Estacion_Trabajo { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Propiedad> Propiedad { get; set; }
    }
}
