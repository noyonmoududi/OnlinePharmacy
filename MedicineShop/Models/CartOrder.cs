using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicineShop.Models
{
    public class CartOrder
    {
        public int Id { get; set; }
   
       
        public string OrderShipName { get; set; }
        
        public string Address { get; set; }
      
        public string District { get; set; }
      
        public string PhoneNo { get; set; }
        
        public string Email { get; set; }
       
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
       
        public bool Status { get; set; }


    }
}