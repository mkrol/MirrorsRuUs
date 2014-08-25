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
        private ICategoryRepository CategoryRepository;
        public CategoryController(ICategoryRepository repo)
        {
            CategoryRepository = repo;
        }
        
        // GET: Admin/Category
        public ActionResult Index()
        {

            UrlHelper helper = new UrlHelper(System.Web.HttpContext.Current.Request.RequestContext); 
            MRU.Web.Models.Category.Admin.CategoryViewModel model = new Models.Category.Admin.CategoryViewModel();
            model.CategoryGridModel.DataUrl = helper.Action("GetCategoriesForGrid", "Category", new { area = "admin" });
            return View("Index", model);
        }

        [HttpGet]
        public JsonResult GetCategoriesForGrid()
        {
            List<Tester> mdk = new List<Tester>();
            mdk.Add(new Tester() { name = "Test", id = "1" });
            mdk.Add(new Tester() { name = "Test2", id = "2" });
            mdk.Add(new Tester() { name = "Test3", id = "3" });
            var obj = new
            {
                blob = mdk
            };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View("_Add");
        }

        [HttpPost]
        public JsonResult Add(CategoryModel model)
        {
            model = CategoryRepository.Save(model);
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
            var cats = CategoryRepository.GetCategoriesForTypeAhead(categoryName).Select(x => new { x.Id, x.Name });
            return Json(cats, JsonRequestBehavior.AllowGet);       
        }
    }

    public class Tester
    {
        public string name { get; set; }
        public string id { get; set; }
    }
}