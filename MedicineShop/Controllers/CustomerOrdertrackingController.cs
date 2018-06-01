using MedicineShop.Models;
using MedicineShop.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace MedicineShop.Controllers
{
    public class CustomerOrdertrackingController : Controller
    {

        private ApplicationDbContext _context;

        public CustomerOrdertrackingController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: CustomerOrdertracking
        [Authorize]
        public ActionResult Index()
        {

            string userId = null;

            var claimsIdentity = User.Identity as ClaimsIdentity;
            if (claimsIdentity != null)
            {

                var userIdClaim = claimsIdentity.Claims
                    .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);

                if (userIdClaim != null)
                {
                    var userIdValue = userIdClaim.Value;
                    userId = userIdValue;
                }
            }
            var order = _context.CartOrders.Where(c => c.UserId == userId).ToList();

            return View(order);
        }
        [Authorize]
        public ActionResult Details(int id)
        {
            var admin = _context.AdminMassages.SingleOrDefault(c => c.CartOrderId == id);
            var courier = _context.CourierMessages.SingleOrDefault(c => c.CartOrderId == id);
            var deliveryMan = _context.DeliveryManMessages.SingleOrDefault(c => c.CartOrderId == id);

            var message = new OrderTrackingViewModel
            {
                adminMassage = admin,
                courierMessage = courier,
                deliveryManMessage = deliveryMan,
                Id = id
                
            };
            return View(message);
        }

        public ActionResult Delete(int id)
        {
            CartOrder cartOrder = _context.CartOrders.Find(id);
            _context.CartOrders.Remove(cartOrder);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [AllowAnonymous]
        public ActionResult DetailsOrder(int id)
        {
            var order = _context.CartOrderDetailses.Where(c => c.CartOrderId == id).ToList();

            return View("Orderreview", order);
        }
    }
}