using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedicineShop.Models;

namespace MedicineShop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PrescriptionController : Controller
    {
        private ApplicationDbContext _context;

        public PrescriptionController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
      [AllowAnonymous]
        public ActionResult Addprescription()
        {
            PrescriptionModel b1 = new PrescriptionModel();
            return View(b1);
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Addprescription(PrescriptionModel model,HttpPostedFileBase image1)
        {
            if (image1 != null)
            {
                model.PrescriptionImage = new byte[image1.ContentLength];
                image1.InputStream.Read(model.PrescriptionImage, 0, image1.ContentLength);

            }

            _context.PrescriptionModels.Add(model);
            _context.SaveChanges();
            //return View(model);
            return View("Success");
        }   
        public ActionResult Viewprescription()
        {
            var item = (from d in _context.PrescriptionModels select d).ToList();
            return View(item);
        }
      
        public ActionResult DisplayImage(int id)
        {
            var item = _context.PrescriptionModels.Single(c => c.Id == id);
            return View(item);
        }

    }
}