﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWinery
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WineryManagementEntities : DbContext
    {
        public static WineryManagementEntities Instance { get; private set; }
        static WineryManagementEntities()
        {
            Instance = new WineryManagementEntities();
        }
        public WineryManagementEntities()
            : base("name=WineryManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        
        public virtual DbSet<Wines> Wines { get; set; }
    }
}
