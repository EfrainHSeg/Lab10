﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab10.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NeptunoDBEntities : DbContext
    {
        public NeptunoDBEntities()
            : base("name=NeptunoDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<categorias> categorias { get; set; }
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<compañiasdeenvios> compañiasdeenvios { get; set; }
        public virtual DbSet<customers> customers { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<invoice_details> invoice_details { get; set; }
        public virtual DbSet<invoices> invoices { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<productos> productos { get; set; }
        public virtual DbSet<products> products { get; set; }
        public virtual DbSet<proveedores> proveedores { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<detallesdepedidos> detallesdepedidos { get; set; }
    }
}