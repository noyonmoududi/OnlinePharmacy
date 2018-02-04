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

        public int Amount { get; set; }

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
                CustomerId = duecustomer.Id,


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
                        Date = DateTime.Now

                    };

                    _context.DueAmounts.Add(dueAmount);
                }
                _context.SaveChanges();


            }
            return RedirectToAction("Index", "Customer");
        }

        public ActionResult DueDetails(int id)
        {
            var due = _context.DueAmounts.Where(c => c.CustomerId == id).ToList();
            return View("DueDetails",due);
        }

        //public ActionResult Less(DueAmount Lessdue)
        //{
        //    var duecustomer = _context.Customers.SingleOrDefault(c => c.Id == Lessdue.CustomerId);
        //    List<double> list = new List<double>();

        //    var data = _context.Customers.ToList();
        //    var data1 = _context.DueAmounts.ToList();

        //    foreach (var group in data)
        //    {
        //        double value = 0;
        //        foreach (var asdf in data1)
        //        {

        //            if (group.Id == asdf.CustomerId)
        //            {

        //                value = value - asdf.Amount;
        //            }

        //        }
        //        group.DueAmounts = value;
        //    }
        //    double[] array = list.ToArray();

        //    //var customer = _context.Customers.ToList();
        //    //return Ok(data);

        //    return RedirectToAction("Index", "Customer");
        //}

    }
}