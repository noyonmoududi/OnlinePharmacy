using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicineShop.ViewModel
{
    public class CourierViewModel
    {
        public int Id { get; set; }
        public string OrderShipName { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public DateTime Orderdate { get; set; }

    }
}