namespace ProductManager.Migrations
{
    using ProductManager.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductManager.DataAccess.ProductManagerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductManager.DataAccess.ProductManagerDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var product1 = new Product
            {
                Name = "Samsung Galaxy S9",
                Category = new Category { Name = "Phones"},
                Description = "Mobile Phone",
                Price = 120000
            };

            var product2 = new Product
            {
                Name = "HP Probook",
                Category = new Category { Name = "Laptops" },
                Description = "Laptop Notebook, 256GB-SSD RAM",
                Price = 250000
            };

            var product3 = new Product
            {
                Name = "Laptop Battery",
                Category = new Category { Name = "Accessory" },
                Description = "10000mah Lithium Ion Battery",
                Price = 20000
            };

            context.Set<Product>().AddOrUpdate(p => p.Name, product1);
            context.Set<Product>().AddOrUpdate(p => p.Name, product2);
            context.Set<Product>().AddOrUpdate(p => p.Name, product3);
        }
    }
}
