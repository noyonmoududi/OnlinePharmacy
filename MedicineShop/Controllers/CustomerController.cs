using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicineShop.Models;

namespace MedicineShop.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            var customer = new Customer();

            return View("Customer", customer);
        }

        public ActionResult Add(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return View("Customer",customer);
            }
            else if (customer.Id== 0)
            {
                _context.Customers.Add(customer);
            }

            _context.SaveChanges();
            return View("Index");

        }
    }
}