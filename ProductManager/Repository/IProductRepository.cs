using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProduct();
    }
}
