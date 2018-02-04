using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MedicineShop.Models;
using System.Data.Entity;
using System.Web.Mvc;

namespace MedicineShop.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetCustomer()
        {
            List<double> list = new List<double>();

            var data = _context.Customers.ToList();
            var data1 = _context.DueAmounts.ToList();

            foreach (var group in data)
            {
                double value = 0;
                foreach (var asdf in data1)
                {
                  
                    if (group.Id == asdf.CustomerId)
                    {
                        
                        value = value + asdf.Amount;
                    }

                }
                group.DueAmounts = value;
            }
            double[] array = list.ToArray();

            //var customer = _context.Customers.ToList();
            return Ok(data);
        }

        public IHttpActionResult DeleteCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return Ok();
        }
    }
}
