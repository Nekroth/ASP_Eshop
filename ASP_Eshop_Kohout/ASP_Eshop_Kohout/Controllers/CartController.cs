﻿using System;
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
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Checkout1()
        {
            //this.ViewBag.Items =
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