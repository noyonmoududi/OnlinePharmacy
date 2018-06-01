using MedicineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedicineShop.ViewModel
{
    public class OrderTrackingViewModel
    {
        public int Id { get; set; }

        public AdminMassage adminMassage { get; set; }

        public CourierMessage courierMessage { get; set; }

        public DeliveryManMessage deliveryManMessage { get; set; }
    }
}