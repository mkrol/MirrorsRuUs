using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MRU.Web.Areas.Customer.Controllers
{

    [Authorize(Roles="Customer")]
    public abstract class SecureController : Controller
    {
        // GET: Customer/Secure

        public ActionResult Index()
        {
            return View();
        }
    }
}