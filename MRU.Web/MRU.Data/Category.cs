using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRU.Web.Models.Category;
using MRU.Data.Interfaces;

namespace MRU.Data
{
    public class Category : ICategory
    {
        private MRUContext context;
        public Category()
        {
            context = new MRUContext();
        }

        public CategoryModel GetById(int id)
        {
            return context.Categories.Where(x => x.Id == id).SingleOrDefault();
        }

        public CategoryModel Get(CategoryModel m)
        {
            return new CategoryModel();
        }

        public List<CategoryModel> GetCategories()
        {
            return context.Categories.ToList();
        }

        public List<CategoryModel> GetParentCategories()
        {
            return context.Categories.Where(x => !x.ParentId.HasValue).ToList();
        }

        public List<CategoryModel> GetChildCategories(int Id)
        {
            return context.Categories.Where(x => x.ParentId == Id).ToList();
        }

        public CategoryModel Add(CategoryModel model)
        {
            return context.Categories.Add(model);
        }

        public bool Delete(int id)
        {
            try
            {
                CategoryModel m = context.Categories.Where(x => x.Id == id).Single();
                context.Categories.Remove(m);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }            
        }
        public CategoryModel Save(CategoryModel m)
        {
            CategoryModel saveMe = context.Categories.Where(x => x.Id == m.Id).Single();
            if (null == saveMe)
            {
                saveMe = context.Categories.Add(m);
            }
            else
            {
                
            }
            return saveMe;
        }
    }
}
