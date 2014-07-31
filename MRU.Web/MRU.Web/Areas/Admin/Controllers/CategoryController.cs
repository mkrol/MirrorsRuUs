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
        private ICategoryRepository CategoryRepo;
        public CategoryController(ICategoryRepository repo)
        {
            CategoryRepo = repo;
        }
        
        // GET: Admin/Category
        public ActionResult Index()
        {
            
            return View("Index", CategoryRepo.GetCategories());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View("_Add");
        }

        [HttpPost]
        public JsonResult Add(CategoryModel model)
        {
            MRU.Data.CategoryRepository repo = new Data.CategoryRepository();
            model = repo.Save(model);
            return Json(model.Id);
        }

        [HttpGet]
        public JsonResult Delete(int Id)
        {
            //MRU.Data.Category repo = new Data.Category();
            return Json(true);
            
        }

        [HttpGet]
        public JsonResult CategoriesTypeAhead(string categoryName)
        {
            var cats = CategoryRepo.GetCategoriesForTypeAhead(categoryName).Select(x => new { x.Id, x.Name });
            return Json(cats, JsonRequestBehavior.AllowGet);       
        }
    }
}