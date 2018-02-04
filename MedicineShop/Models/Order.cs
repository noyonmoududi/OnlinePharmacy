using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace MedicineShop.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}