﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessLogic
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBPROJECTEntities : DbContext
    {
        public DBPROJECTEntities()
            : base("name=DBPROJECTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<workout_active> workout_active { get; set; }
        public virtual DbSet<workout_Category> workout_Category { get; set; }
        public virtual DbSet<workout_Collection> workout_Collection { get; set; }
    }
}
