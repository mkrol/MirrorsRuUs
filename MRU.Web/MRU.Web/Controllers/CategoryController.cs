using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MRU.Web.Models.Category;
using MRU.Data.Interfaces;

namespace MRU.Web.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository CategoryRepository;

        public CategoryController(ICategoryRepository repo)
        {
            CategoryRepository = repo;
        }
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public bool Add(CategoryModel m)
        {
            return true;
        }

        [HttpGet]
        public PartialViewResult GetCategories()
        {

            return PartialView("_Categories");
        }
    }
}