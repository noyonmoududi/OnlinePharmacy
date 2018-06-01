using MedicineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MedicineShop.Controllers
{
    [Authorize(Roles = "DeliveryMan")]
    public class DeliveryManMessageController : Controller
    {
        private ApplicationDbContext _context;

        public DeliveryManMessageController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: DeliveryManMessage
        public ActionResult Index()
        {
            
            var data = _context.CourierMessages.Include(c => c.AdminMassage).Include(c => c.CartOrder).ToList();

            return View(data);
        }

        public ActionResult Send(int id, int cartId)
        {
            var data = _context.CourierMessages.SingleOrDefault(c => c.Id == id);
            if (data != null)
            {
                data.Status = true;
                _context.SaveChanges();
            }

            var send = new DeliveryManMessage
            {
                CourierMessageId = id,
                CartOrderId = cartId,
            };

            return View(send);
        }
        public ActionResult SendMessage(DeliveryManMessage deliveryManMessage)
        {
            if (ModelState.IsValid)
            {
                deliveryManMessage.DateTime = DateTime.Now;
                deliveryManMessage.Status = false;

                _context.DeliveryManMessages.Add(deliveryManMessage);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");

         
        }

    }
}