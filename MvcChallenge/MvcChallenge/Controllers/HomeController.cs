using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcChallenge.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult AllData()
        {
            ViewBag.Message = "Your page to view all";

            var db = new MvcChallenge.Models.Model1();
            var Alldb = new MvcChallenge.Models.ViewModel();
            Alldb.Customers = db.Customers.ToList();
            Alldb.Orders = db.Orders.ToList();
            Alldb.Products = db.Products.ToList();

            return View(Alldb);
        }
    }
}