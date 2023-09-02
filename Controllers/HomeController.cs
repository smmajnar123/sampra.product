using Sampra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sampra.Controllers
{
    public class HomeController : Controller
    {
      
        public ActionResult Index()
        {
            ProductsData productsData = new ProductsData();
            return View(productsData);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact details";

            return View();
        }
    }
}