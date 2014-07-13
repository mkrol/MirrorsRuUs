using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MRU.Web.Areas.Customer.Controllers
{
    public class OrderController : Controller
    {
        // GET: Customer/Order
        public ActionResult Index()
        {
            return View();
            
        }
    }
}