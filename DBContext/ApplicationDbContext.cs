using Entitys;
using Microsoft.EntityFrameworkCore;
using System;

namespace DBContext
{
    public class ApplicationDbContext : DbContext
    {
        //string DbPath;
        public ApplicationDbContext()
        {
            //this.DbPath = DbPath;
        }

        
        public DbSet<TaxExemptVehicles> TaxExemptVehicles { get; set; }
        public DbSet<TaxRules> TaxRules { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
       => options.UseSqlServer("Server=.; Initial Catalog= TaxTest; Integrated Security=true;");
    }
}
