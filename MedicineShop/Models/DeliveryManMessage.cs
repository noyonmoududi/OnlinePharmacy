using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MedicineShop.Models
{
    public class DeliveryManMessage
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Message")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Please Enter your PhoneNo")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Please Enter Your Current Location")]
        public string Location { get; set; }
        public DateTime DateTime { get; set; }

        public CourierMessage CourierMessage { get; set; }
        public int CourierMessageId { get; set; }
        [Required]
        public bool Status { get; set; }

        [ForeignKey("CartOrderId")]
        public CartOrder CartOrder { get; set; }
        public int? CartOrderId { get; set; }

    }
}