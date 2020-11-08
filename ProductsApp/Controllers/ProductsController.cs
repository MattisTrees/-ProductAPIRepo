using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "DVD Player", Category = "Antiquated Technologies", Price = 25.450M },
            new Product { Id = 2, Name = "Pogo Stick", Category = "Old Ass Toys", Price = 30.75M },
            new Product { Id = 3, Name = "Lathe", Category = "Tools nobody knows how to use", Price = 16000.99M },
            new Product { Id = 4, Name = "This is the 4th Item!", Category = "Items", Price = 420.69M }
        };

        public ProductsController()
        {

        }

        public ProductsController(Product[] products)
        {
            this.products = products;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
