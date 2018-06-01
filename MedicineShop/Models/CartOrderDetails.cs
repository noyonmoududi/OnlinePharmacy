using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicineShop.Models
{
    public class CartOrderDetails
    {
        public int Id { get; set; }
        public CartOrder CartOrder { get; set; }
        public int CartOrderId { get; set; }

        public Product Product { get; set; }
        public int ProductId { get; set; }

        public float Price { get; set; }
        public int Quantity { get; set; }
        public float SubTotal { get; set; }
    }
}