using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using MedicineShop.Models;


namespace MedicineShop.Controllers
{
    public class ShoppingCartController : Controller
    {
      
        private ApplicationDbContext _context;
        private string strItem = "cart";
       

        

        public ShoppingCartController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: ShoppingCart
       
        private int isExisting(int id)
        {

            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)

                if (cart[i].Pr.Id == id)
                    return i;

            return -1;

        }

        public ActionResult Delete(int id)
        {
            int index = isExisting(id);
            List<Item> cart = (List<Item>)Session["cart"];
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return View("Cart");
        }

        public ActionResult OrderNow(int id)
        {
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item(_context.Products.Find(id), 1));
                Session["cart"] = cart;
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExisting(id);
                if (index == -1)
                    cart.Add(new Item(_context.Products.Find(id), 1));
                else
                    cart[index].Quantity++;
                Session["cart"] = cart;
            }
            return View("Cart");
        }

        public ActionResult Update(FormCollection fc)
        {


            string[] quantities = fc.GetValues("quantity");
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)

                cart[i].Quantity = Convert.ToInt32(quantities[i]);


            Session["cart"] = cart;
            return View("Cart");


        }
        [Authorize]
        public ActionResult CheckOut()
        {

            return View("CheckOut");

        }
        [Authorize]
        public ActionResult ProcessOrder(FormCollection fc)
        {

            string userId = null;

            var claimsIdentity = User.Identity as ClaimsIdentity;
            if (claimsIdentity != null)
            {
              
                var userIdClaim = claimsIdentity.Claims
                    .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);

                if (userIdClaim != null)
                {
                   var userIdValue = userIdClaim.Value;
                    userId = userIdValue;
                }
            }


            List<Item> cart = (List<Item>) Session["cart"];

          

                CartOrder order = new CartOrder()
                {
                    OrderShipName = fc["cusName"],
                    Address = fc["cusAddress"],
                    District = fc["cusDistrict"],
                    PhoneNo = fc["cusPhone"],
                    Email = fc["cusEmail"],
                    UserId = userId,
                    OrderDate = DateTime.Now,
                    Status = false

                    //TotalAmount = sum + Item.pr.Price * Item.Quantity


                };
          
                _context.CartOrders.Add(order);
          
                _context.SaveChanges();

          
                foreach (Item item in cart)
            {
                CartOrderDetails orderDetails = new CartOrderDetails()
                {
                    CartOrderId = order.Id,
                    ProductId = item.Pr.Id,
                    Quantity = item.Quantity,
                    Price = item.Pr.Price,
                    SubTotal = item.Pr.Price * item.Quantity

                };
                _context.CartOrderDetailses.Add(orderDetails);
              

               
                _context.SaveChanges();

            

            }
            Session.Remove(strItem);
            return View("OrderSuccess");
        }

    }
}