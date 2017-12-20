using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicineShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Group { get; set; }
        public string CompannyName { get; set; }
        public float Price { get; set; }
        public string Location { get; set; }
    }
}