using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicineShop.Models
{
    public class PrescriptionModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Your Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter PhoneNo")]
        public string PhoneNo { get; set; }
        [Required(ErrorMessage = "Please Select your File")]
        public byte[] PrescriptionImage { get; set; }


    }
}