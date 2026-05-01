using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirst.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            int ProductId = 1;
            string ProductName = "Apple";
            string Quantity = "1 Dozen";
            decimal Price = 100.00m;
            bool Status = false;
            ViewData["ProductId"] = ProductId;
            ViewData["ProductName"] = ProductName;
            ViewData["Quantity"] = Quantity;
            ViewData["Price"] = Price;
            ViewData["Status"] = Status;

            return View();
        }
    }
}