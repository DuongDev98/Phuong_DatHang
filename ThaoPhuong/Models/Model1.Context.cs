﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThaoPhuong.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class THAOPHUONGEntities : DbContext
    {
        public THAOPHUONGEntities()
            : base("name=THAOPHUONGEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DANH> DANHs { get; set; }
        public virtual DbSet<DKHACHHANG> DKHACHHANGs { get; set; }
        public virtual DbSet<DQUAY> DQUAYs { get; set; }
        public virtual DbSet<DTRANGTHAI> DTRANGTHAIs { get; set; }
        public virtual DbSet<TDONHANG> TDONHANGs { get; set; }
        public virtual DbSet<TDONHANGCHITIET> TDONHANGCHITIETs { get; set; }
        public virtual DbSet<TTHANHTOAN> TTHANHTOANs { get; set; }
        public virtual DbSet<TTHANHTOANCHITIET> TTHANHTOANCHITIETs { get; set; }
        public virtual DbSet<TTHUCHI> TTHUCHIs { get; set; }
    }
}
