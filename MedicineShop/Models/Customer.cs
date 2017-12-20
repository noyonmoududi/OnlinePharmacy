using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicineShop.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string Village { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        public string City { get; set; }
        public string District { get; set; }

    }
}