using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicineShop.ViewModel;
using Microsoft.Ajax.Utilities;
using MedicineShop.Models;

namespace MedicineShop.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext _context;

        public OrderController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        private int i = 0;
       
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add(OrderViewModel orderViewModel)
        {
            var product = _context.Products.ToList();
            foreach (var data in orderViewModel.Products)
            {
                if (string.IsNullOrWhiteSpace(data))
                    break;
                i = i + 1;

                foreach (var quantity in orderViewModel.Quentity)
                {
                    var count = quantity[i - 1];

                    if(count == i)
                        break;

                    //prise = 
                }

            }

            return RedirectToAction("Save");
        }

        public ActionResult Save(OrderViewModel orderViewModel)
        {
            return View();
        }
    }
}