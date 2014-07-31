using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MRU.Data;

namespace MRU.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult GetProducts()
        {
            return PartialView("_Products", new ProductRepository().GetActiveProducts());
        }
    }
}