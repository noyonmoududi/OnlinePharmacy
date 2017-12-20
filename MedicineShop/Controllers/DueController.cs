using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicineShop.Models;
using MedicineShop.ViewModel;

namespace MedicineShop.Controllers
{
    public class DueController : Controller
    {

        private ApplicationDbContext _context;

        public DueController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Due
        public ActionResult Index(int id)
        {
            var duecustomer = _context.Customers.Single(c => c.Id == id);

            var dueAmount = new DueCustomerViweModel
            {
                CustomerName = duecustomer.CustomerName,
                CustomerId = duecustomer.Id

            };


            return View("Index", dueAmount);
        }

        public ActionResult Add(DueAmount due)
        {
            var duecustomer = _context.Customers.SingleOrDefault(c => c.Id == due.CustomerId);

            if (ModelState.IsValid)
            {
                if (duecustomer != null)
                {
                    var dueAmount = new DueAmount
                    {
                        CustomerId = duecustomer.Id,
                        Amount = due.Amount,
                        Date = DateTime.Today

                    };

                    _context.DueAmounts.Add(dueAmount);
                }
                _context.SaveChanges();


            }
            return RedirectToAction("Index", "Customer");
        }

    }
}