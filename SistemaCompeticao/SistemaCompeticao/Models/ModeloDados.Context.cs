﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaCompeticao.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModeloDadosContainer : DbContext
    {
        public ModeloDadosContainer()
            : base("name=ModeloDadosContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<Battle> Battle { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<Artist_has_Competition> Artist_has_Competition { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<Instrument> Instrument { get; set; }
        public virtual DbSet<Music> Music { get; set; }
        public virtual DbSet<Artist_has_Music> Artist_has_Music { get; set; }
    }
}
