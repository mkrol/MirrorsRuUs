﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MRU.Data;

namespace MRU.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            MRUContext m = new MRUContext();
            var cats = m.Categories.ToList();

            return View();
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}