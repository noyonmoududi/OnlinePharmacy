using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MedicineShop.Models;

namespace MedicineShop.ViewModel
{
    public class OrderViewModel
    {
        public List<string> Products { get; set; }
        public List<string> Quentity { get; set; }
        public Order Order { get; set; }
    }
}