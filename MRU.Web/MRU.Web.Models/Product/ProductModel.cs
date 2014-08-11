using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRU.Web.Models.Category;
using NPoco;
using System.ComponentModel.DataAnnotations;


namespace MRU.Web.Models.Product
{
    [TableName("Product")]
    public class ProductModel : AModel 
    {
        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name="Short Description")]
        public string ShortDescription { get; set; }
        [DataType(DataType.Upload)]
        public string Image { get; set; }
        [DataType(DataType.Currency)]
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
