using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRU.Web.Models.Category;

namespace MRU.Data
{
    public class Category
    {
        public List<CategoryModel> GetCategories()
        {
            return new MRUContext().Categories.ToList();
        }

        public List<CategoryModel> GetParentCategories()
        {
            return new MRUContext().Categories.Where(x => !x.ParentId.HasValue).ToList();
        }

        public List<CategoryModel> GetChildCategories(int Id)
        {
            return new MRUContext().Categories.Where(x => x.ParentId == Id).ToList();
        }

        public CategoryModel Add(CategoryModel model)
        {
            return new MRUContext().Categories.Add(model);
        }
    }
}
