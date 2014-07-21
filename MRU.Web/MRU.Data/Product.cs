using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRU.Web.Models;
using MRU.Data.Interfaces;

namespace MRU.Data
{
    public class Product : IProduct
    {
        private MRUContext context;
        public Product()
        {
            context = new MRUContext();
        }
        public List<ProductModel> GetActiveProducts()
        {
            return context.Products.Where(x => x.Active == true && x.Deleted==false).ToList();
        }

        public ProductModel Get(ProductModel m)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetProducts()
        {
            return context.Products.ToList();
        }

        public ProductModel GetById(int Id)
        {
            return new MRUContext().Products.Where(x => x.Id == Id).SingleOrDefault();
        }

        public ProductModel Save(ProductModel m)
        {
            ProductModel saveMe = context.Products.Add(m);
            return saveMe;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
