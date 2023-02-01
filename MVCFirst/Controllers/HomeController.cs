using MVCFirst.Models;
using System;
using System.Web.Mvc;

namespace MVCFirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Add action logic here
            throw new NotImplementedException();
        }

        // GET: Details
        public ActionResult Details(int id = 1)
        {
            var product = new Products(id, "Laptop", 100);
            return View("Details", product);
        }
    }
}