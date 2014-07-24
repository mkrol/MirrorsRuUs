using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MRU.Web.Models;
using NPoco;

namespace MRU.Web.Models.Category 
{
    [TableName("Category")]
    [PrimaryKey("Id")]
    public class CategoryModel : AModel
    {
        [Display(Name = "Parent Category")]
        public int? ParentId { get; set; }
        [Display(Name="Category Name")]
        public string Name { get; set; }
    }
}
