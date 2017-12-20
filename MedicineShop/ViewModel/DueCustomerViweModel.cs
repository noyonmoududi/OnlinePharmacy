using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MedicineShop.Models;

namespace MedicineShop.ViewModel
{
    public class DueCustomerViweModel
    {
        public string CustomerName { get; set; }

        public int CustomerId { get; set; }
        [Required]
        public int Amount { get; set; }

        public DateTime Date { get; set; }
    }
}