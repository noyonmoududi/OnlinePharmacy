﻿using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using MedicineShop.Models;

namespace MedicineShop.Controllers
{
    public class Item
    {
        private Product pr = new Product();

        public Product Pr
        {
            get { return pr; }
            set { pr = value; }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


        public Item()
        {

        }

        public Item(Product product, int quantity)
        {
            this.pr = product;
            this.quantity = quantity;
        }
    }
}