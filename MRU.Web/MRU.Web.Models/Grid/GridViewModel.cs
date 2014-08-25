using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRU.Web.Models.Grid
{
    public class GridViewModel
    {
        public string Id { get; set; }
        public List<string> Classes { get; set; }
        public List<GridColumnViewModel> Columns { get; set; }
        public string DataUrl { get; set; }

        public GridViewModel()
        {
            Id = "MRUGrid";
            DataUrl = "";
            Classes = new List<string>();
            Columns = new List<GridColumnViewModel>();
        }
    }
}
