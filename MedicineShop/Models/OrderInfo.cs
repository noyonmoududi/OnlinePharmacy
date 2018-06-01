using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicineShop.Models
{
    public class OrderInfo
    {
        public List<string> Products { get; set; }
        public List<int> Quentity { get; set; }
    }
}