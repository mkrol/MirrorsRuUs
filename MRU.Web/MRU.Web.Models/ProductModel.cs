using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MRU.Web.Models.Category;

namespace MRU.Web.Models
{
    [Table("Product")]
    public class ProductModel : AModel 
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Length { get; set; }
        public double Weight { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public virtual ICollection<CategoryModel> Categories { get; set; }
    }
}
