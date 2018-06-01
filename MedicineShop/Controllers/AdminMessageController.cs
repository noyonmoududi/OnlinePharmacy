using MedicineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicineShop.Controllers
{
    public class AdminMessageController : Controller
    {
        private ApplicationDbContext _context;

        public AdminMessageController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: AdminMessage
        public ActionResult Index(int id)
        {
            var data = _context.CartOrders.SingleOrDefault(c => c.Id == id);
            if(data != null)
            {
                data.Status = true;
                _context.SaveChanges();
            }

            var send = new AdminMassage
            {
                CartOrderId = id
            };

            return View(send);
        }
        public ActionResult SendMessage(AdminMassage adminMassage)
        {
            if (ModelState.IsValid)
            {
                adminMassage.DateTime = DateTime.Today;
                adminMassage.Status = false;

                _context.AdminMassages.Add(adminMassage);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "CartOrders");
        }
      


        

}
}