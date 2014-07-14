using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRU.Web.Models;

namespace MRU.Data
{
    public class Product
    {
        public Product()
        {

        }
        public List<ProductModel> GetActiveProducts()
        {
            return new MRUContext().Products.Where(x => x.Active == true && x.Deleted==false).ToList();
        }

        public List<ProductModel> GetProducts()
        {
            return new MRUContext().Products.ToList();
        }

        public ProductModel GetProduct(int Id)
        {
            return new MRUContext().Products.Where(x => x.Id == Id).SingleOrDefault();
        }

        public bool Save(ProductModel m)
        {
            new MRUContext().Products.Add(m);
            return true;
        }
    }
}
