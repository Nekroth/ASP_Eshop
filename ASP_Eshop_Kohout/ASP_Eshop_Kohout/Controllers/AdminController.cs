﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        //private MyContext context = new MyContext();
        private List<string> products = new List<string>() { "Product1", "Product2", "Product3" };

        // GET: Admin
        public ActionResult Index()
        {
            //this.ViewBag.Products = this.context.People.ToList();
            this.ViewBag.Products = products;

            return View();
        }
    }
}