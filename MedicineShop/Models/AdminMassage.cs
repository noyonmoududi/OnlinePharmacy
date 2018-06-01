using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicineShop.Models
{
    public class AdminMassage
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Message")]
        public string Massage { get; set; }

        [Required(ErrorMessage = "Please Enter your current location")]
        public string Location { get; set; }
     
        public DateTime DateTime { get; set; }

        public CartOrder CartOrder { get; set; }
        public int CartOrderId { get; set; }

        [Required]
        public bool Status { get; set; }


    }
}