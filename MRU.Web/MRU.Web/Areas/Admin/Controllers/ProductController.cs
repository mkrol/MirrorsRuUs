﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MRU.Web.Areas.Admin.Controllers
{
    public class ProductController : SecureController
    {
        // GET: Admin/Product
        public ActionResult Index()
        {
            return View();
        }
    }
}