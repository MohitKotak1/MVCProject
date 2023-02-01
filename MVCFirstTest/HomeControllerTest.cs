using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCFirst.Controllers;
using MVCFirst.Models;
using System.Web.Mvc;

namespace MVCFirstTest
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void TestHomeDetails()
        {
            var controller = new HomeController();
            var result = controller.Details(2) as ViewResult;
            var product = (Products)result.ViewData.Model;
            Assert.AreEqual("Mobile", product.Name);
            Assert.AreEqual(200, product.Price);
        }
    }
}
