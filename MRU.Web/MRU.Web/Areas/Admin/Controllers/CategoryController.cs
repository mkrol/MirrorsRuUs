using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MRU.Web.Models.Category;

namespace MRU.Web.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Admin/Category
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View("_Add");
        }

        [HttpPost]
        public ActionResult Add(CategoryModel model)
        {
            MRU.Data.Category repo = new Data.Category();
            repo.Add(model);
            return null;
        }
    }
}