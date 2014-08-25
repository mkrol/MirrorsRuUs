using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRU.Web.Models.Grid
{
    public class GridColumnViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ToolTip { get; set; }
        public bool Sortable { get; set; }
        public bool Hidden { get; set; }
        public GridColumnFormatEnum Format { get; set; }
    }
}
