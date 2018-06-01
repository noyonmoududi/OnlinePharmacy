using MedicineShop.Models;
using MedicineShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MedicineShop.Controllers
{
    [Authorize(Roles = "Courier")]
    public class CourierMassageController : Controller
    {
        private ApplicationDbContext _context;

        public CourierMassageController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: CourierMassage
        public ActionResult Index()
        {
            //var data = _context.AdminMassages.Include(c => c.CartOrders).Where(c => c.Status == true).ToList();
            var data = _context.AdminMassages.Include(c => c.CartOrder).Where(c => c.Status == false).ToList();
            
            return View(data);
           
        }

        public ActionResult Send(int id, int cartId)
        {
            var data = _context.AdminMassages.SingleOrDefault(c => c.Id == id);
            if (data != null)
            {
                data.Status = true;

                _context.SaveChanges();
            }

            var send = new CourierMessage
            {
                AdminMassageId = id,
                CartOrderId = cartId,
               
        };
           
            return View(send);
        }

        public ActionResult SendMessage(CourierMessage courierMassage)
        {
            if (ModelState.IsValid)
            {
                courierMassage.DateTime = DateTime.Now;
                courierMassage.Status = false;

                _context.CourierMessages.Add(courierMassage);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}