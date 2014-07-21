using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MRU.Web.Models;

namespace MRU.Web.Models.Category 
{
    [Table("Category")]
    public class CategoryModel : AbstractModel
    {
        public int Id { get; set; }
        [Display(Name = "Parent Category")]
        public int? ParentId { get; set; }
        [Display(Name="Category Name")]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
