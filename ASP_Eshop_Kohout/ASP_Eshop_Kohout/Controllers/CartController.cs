using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CartController : Controller
    {
        private MainContext context = new MainContext();
        private CheckoutCart checkout = new CheckoutCart();
        public ActionResult Index()
        {
            this.ViewBag.Items = Session["checkout"];
            return View();
        }
        public ActionResult AddItem(string name, string image)
        {
            if (Session["checkout"] != null)
            {
                checkout.products = (List<Product>)Session["checkout"];
            }       
            Product toAdd = new Product() { Name = name, Image = image };
            checkout.products.Add(toAdd);
            Session["checkout"] = checkout.products;
            return RedirectToAction("Index", "Cart");
        }

        public ActionResult Checkout1()
        {
            this.ViewBag.Items = Session["checkout"];
            return View();
        }
        public ActionResult Checkout2()
        {
            return View();
        }
        public ActionResult Checkout3()
        {
            return View();
        }
        public ActionResult Checkout4()
        {
            return View();
        }
    }
}