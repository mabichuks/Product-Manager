using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductManager.DataAccess
{
    public class ProductManagerDbContext: DbContext
    {
        public ProductManagerDbContext(): base("ProductManagerDbContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }

        public DbSet<Product> Products { get; set; }

    }
}