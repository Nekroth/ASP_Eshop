using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BlogController : Controller
    {
        private MainContext context = new MainContext();
        public ActionResult Index()
        {
            this.ViewBag.Blogs = this.context.blogs.ToList();
            return View();
        }
        public ActionResult Detail(int? id)
        {
            this.ViewBag.Blog = this.context.blogs.ToList().Find(t => t.ID == id);
            return View();
        }
    }
}