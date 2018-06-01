using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicineShop.Models
{
    public class DueAmount
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }

        public int CustomerId { get; set; }
        [Required]
        public int Amount { get; set; }

        public DateTime Date { get; set; }



    }
}