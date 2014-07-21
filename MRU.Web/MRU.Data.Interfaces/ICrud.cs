using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRU.Web.Models;

namespace MRU.Data.Interfaces
{
    public interface ICrud <T> where T : AbstractModel 
    {
        T Save(T model);
        bool Delete(int id);
        T Get(T model);
        T GetById(int Id);
    }
}
