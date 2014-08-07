using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRU.Web.Models.Category;

namespace MRU.Data.Interfaces
{
    public interface ICategoryRepository : ICrud<CategoryModel>
    {
        List<CategoryModel> GetCategoriesForTypeAhead(string categoryName);
        List<CategoryModel> GetCategories();
    }
}
