using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MRU.Web.Models.Category;
using MRU.Data.Interfaces;

namespace MRU.Web.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public ICategory CategoryRepo;
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
        public JsonResult Add(CategoryModel model)
        {
            MRU.Data.Category repo = new Data.Category();
            model = repo.Add(model);
            return Json(model.Id);
        }

        [HttpGet]
        public JsonResult Delete(int Id)
        {
            //MRU.Data.Category repo = new Data.Category();
            return Json(true);
            
        }
    }
}