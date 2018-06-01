using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicineShop.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Your ProductName")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Product Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please Enter Your Product Group")]
        public string Group { get; set; }

        [Required(ErrorMessage = "Please Enter your product Company")]
        public string CompannyName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Product price")]
        public float Price { get; set; }

        [Required(ErrorMessage = "Where do you keep your product!")]
        public string Location { get; set; }
    }
}