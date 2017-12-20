using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicineShop.Models;

namespace MedicineShop.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _context;

        public ProductController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Product
        public ActionResult Index()
        {
            //var product = _context.Products.ToList();

            return View();
        }
        public ActionResult New()
        {
            var product = new Product();
            return View("Product", product);
        }
        public ActionResult Add(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View("Product", product);
            }
            else if (product.Id== 0)
            {
                _context.Products.Add(product);
              
            }
            else
            {
                var data = _context.Products.Single(p => p.Id == product.Id);
                data.ProductName = product.ProductName;
                data.Description = product.Description;
                data.CompannyName = product.CompannyName;
                data.Group = product.Group;
                data.Price = product.Price;
                

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Product");
        }

        public ActionResult Edit(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            else
            {

                return View("Product", product);
            }

            
        }

        public ActionResult Delete(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return HttpNotFound();
            }
            _context.Products.Remove(product);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}