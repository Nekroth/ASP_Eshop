using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        private MainContext context = new MainContext();

        public ActionResult Index()
        {
            this.ViewBag.Products = this.context.products.ToList();
            return View();
        }
        public ActionResult Detail(int? id)
        {
            this.ViewBag.Product = this.context.products.ToList().Find(t => t.ID == id);
            return View();
        }
        public ActionResult BuyProduct(int? id)
        {
            //this.context.orders.ad
            return RedirectToAction("Index","Cart");
        }
    }
}