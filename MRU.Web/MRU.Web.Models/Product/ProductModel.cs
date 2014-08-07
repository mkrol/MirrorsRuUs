using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRU.Web.Models.Category;
using NPoco;

namespace MRU.Web.Models.Product
{
    [TableName("Product")]
    public class ProductModel : AModel 
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public bool Taxable { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public virtual ICollection<CategoryModel> Categories { get; set; }
    }
}
