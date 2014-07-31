using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRU.Web.Models;
using MRU.Data.Interfaces;

namespace MRU.Data
{
    public class ProductRepository : ADataContext<ProductModel>, IProductRepository
    {
        
        public ProductRepository()
        {
     
        }
        public List<ProductModel> GetActiveProducts()
        {
            return MRUDatabase.Fetch<ProductModel>("where isdeleted <> 1");
        }

        public ProductModel Get(ProductModel m)
        {
            throw new NotImplementedException();
        }

        public List<ProductModel> GetProducts()
        {
            return MRUDatabase.Fetch<ProductModel>();
        }
    }
}
