using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRU.Web.Models
{
    public abstract class AbstractModel
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
