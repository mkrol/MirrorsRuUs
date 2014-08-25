using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MRU.Data.Interfaces;
using MRU.Web.Models.Product;

namespace MRU.Web.Areas.Admin.Controllers
{
    public class ProductController : SecureController
    {
        private IProductRepository ProductRepository;
        public ProductController (IProductRepository repo)
        {
            ProductRepository = repo;
        }

        // GET: Admin/Product
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int Id)
        {
            return View("Edit");
        }

        [HttpGet]
        public PartialViewResult Add()
        {
            return PartialView("_Add");
        }

        [HttpPost] 
        public JsonResult Add(ProductModel model)
        {
            model = ProductRepository.Save(model);
            return Json(model.Id);
        }

        [HttpGet]
        public JsonResult  GetProductsForGrid()
        {
            return Json(0);
        }
    }
}