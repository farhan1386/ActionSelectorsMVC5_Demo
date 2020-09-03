using ActionSelectorsMVC5_Demo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionSelectorsMVC5_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        [ActionName("List")]
        public ActionResult Index()
        {
            var products = db.Products.ToList();
            return View(products);
        }
    }
}