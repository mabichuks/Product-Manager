using ProductManager.DataAccess;
using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManager.Repository
{
    public  class ProductRepository : IProductRepository
    {
        private ProductManagerDbContext ctxt = new ProductManagerDbContext();

        public ProductRepository()
        {
            this.ctxt = new ProductManagerDbContext();
        }

        public IEnumerable<Product> GetProduct()
        {
            return ctxt.Products;
        }
    }
}