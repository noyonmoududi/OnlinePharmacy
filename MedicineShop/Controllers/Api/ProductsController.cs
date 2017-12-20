using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MedicineShop.Models;

namespace MedicineShop.Controllers.Api
{
    public class ProductsController : ApiController
    {
        private ApplicationDbContext _context;
        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetProduct()
        {
            var product = _context.Products.ToList();
            return Ok(product);
        }

        public IHttpActionResult DeleteProduct(int id)
        {
            var product = _context.Products.SingleOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return Ok();
        }
    }
}
