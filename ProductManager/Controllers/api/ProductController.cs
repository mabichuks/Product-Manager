using ProductManager.DataAccess;
using ProductManager.Models;
using ProductManager.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductManager.Controllers.api
{
    [RoutePrefix("api/productapi")]
    public class ProductController : ApiController
    {
        private ProductRepository repo;
        public ProductController()
        {
            this.repo = new ProductRepository();
        }

        [HttpGet]
        [Route("getproducts")]
        public HttpResponseMessage GetAllProducts()
        {
            try
            {
               var products = repo.GetProduct().ToList();
                return this.Request.CreateResponse<IEnumerable<Product>>(HttpStatusCode.OK, products);
            }
            catch (Exception ex)
            {

                return this.Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
    }
}
