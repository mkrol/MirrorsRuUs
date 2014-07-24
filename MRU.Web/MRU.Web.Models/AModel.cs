using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using NPoco;

namespace MRU.Web.Models
{
    [PrimaryKey("Id")]
    public abstract class AModel
    {
        public int Id { get; set; }
        [Display(Name="Created Date")]
        public DateTime CreatedDate { get; set; }
    }
}
