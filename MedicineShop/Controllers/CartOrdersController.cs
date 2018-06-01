using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MedicineShop.Models;

namespace MedicineShop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CartOrdersController : Controller
    {
        private ApplicationDbContext _context;

        public int Amount { get; set; }

        public CartOrdersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: CartOrders
        public ActionResult Index()
        {
            var data = _context.CartOrders.Where(c => c.Status == false).ToList();
            return View(data);
        }


        // GET: CartOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CartOrder cartOrder = _context.CartOrders.Find(id);
            if (cartOrder == null)
            {
                return HttpNotFound();
            }
            return View(cartOrder);
        }

        // POST: CartOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CartOrder cartOrder = _context.CartOrders.Find(id);
            _context.CartOrders.Remove(cartOrder);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [AllowAnonymous]
        public ActionResult Orderreview(int id)
        {
            var order = _context.CartOrderDetailses.Where(c => c.CartOrderId == id).ToList();

            return View("Orderreview", order);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
