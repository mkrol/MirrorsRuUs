using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRU.Web.Models.Category;
using MRU.Data.Interfaces;
using NPoco;

namespace MRU.Data
{
    public class Category : ADataContext<CategoryModel>, ICategory
    {        
        public Category() : base()
        {
        }

        public CategoryModel GetById(int id)
        {
            CategoryModel m = MRUDatabase.SingleById<CategoryModel>(id);
            return m;
        }

        public CategoryModel Get(CategoryModel m)
        {
            return new CategoryModel();
        }

        public List<CategoryModel> GetCategories()
        {
            return MRUDatabase.Fetch<CategoryModel>();
        }

        public List<CategoryModel> GetParentCategories()
        {
            return MRUDatabase.Fetch<CategoryModel>("where parentid is null");
        }

        public List<CategoryModel> GetChildCategories(int Id)
        {
            return MRUDatabase.Fetch<CategoryModel>("where parentid = @0", Id);
        }

        
        public List<CategoryModel> GetCategoriesForTypeAhead(string categoryName)
        {
            return MRUDatabase.Fetch<CategoryModel>("where Name like '@0'", categoryName);
        }
    }
}
