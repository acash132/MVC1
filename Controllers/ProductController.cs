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
        public ActionResult Index1()
        {
            int ProductId = 1;
            string ProductName = "Apple";
            string Quantity = "1 Dozen";
            decimal Price = 100.00m;
            bool Status = false;
           ViewBag.ProductId = ProductId;
            ViewBag.ProductName = ProductName;
            ViewBag.Quantity = Quantity;
            ViewBag.Price = Price;
            ViewBag.Status = Status;

            return View();
        }
        public ActionResult Redirect() {
            ViewBag.messages = "This is a view bag message";
            ViewData["message"] = "This is a view data message";
            TempData["Data"] = "This is a temp data message";
            Session["SessionData"] = "This is a session data message";

            return RedirectToAction("Success");
        
        }
        public ActionResult Success() {
           
            return View();
        }


    }
}