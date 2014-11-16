using FactItSystem.Data;
using FactItSystem.Data.Common.Repository;
using FactItSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactItSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Post> posts;
        //public HomeController()
        //    : this(new GenericRepository<Post>(new ApplicationDbContext()))
        //{ }
        public HomeController(IRepository<Post> posts)
        {
            this.posts = posts;
        }
        public ActionResult Index()
        {
            var posts = this.posts.All();
            return View(posts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}