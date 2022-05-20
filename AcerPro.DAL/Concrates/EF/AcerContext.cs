
using AcerPro.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace AcerPro.DAL.Concrates.EF
{
    public class AcerContext : DbContext
    {
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
        
        public virtual DbSet<Country> CountryDtos { get; set; }


    }
}
