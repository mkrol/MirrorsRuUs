using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRU.Web.Models.Grid;

namespace MRU.Web.Models.Category.Admin
{
    public class CategoryViewModel
    {
        public GridViewModel CategoryGridModel { get; set; }

        public CategoryViewModel()
        {
            CategoryGridModel = new GridViewModel();
            CategoryGridModel.Columns.Add(new GridColumnViewModel() { Name = "Id", Id = "Id", Sortable = true });
            CategoryGridModel.Columns.Add(new GridColumnViewModel() { Name = "Name", Id = "Name", Sortable = true });
            

        }
    }

}
