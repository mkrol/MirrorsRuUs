using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRU.Web.Models;

namespace MRU.Data.Interfaces
{
    public interface ICrud <T> where T : AModel 
    {
        T Save(T model);
        T Update(T updateMe);
        bool Delete(int id);
        T GetById(int Id);
    }
}
