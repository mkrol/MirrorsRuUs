using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRU.Web.Models.Product;

namespace MRU.Data.Interfaces
{
    public interface IProductRepository : ICrud<ProductModel>
    {
    }
}
