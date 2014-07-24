using NPoco;
using MRU.Data.Interfaces;
using MRU.Web.Models;

namespace MRU.Data
{
    public abstract class ADataContext<T> : ICrud<T> where T : AModel
    {
        protected IDatabase MRUDatabase = null;
        
        public ADataContext()
        {
            MRUDatabase = new Database("DefaultConnection");
        }
        public T Save(T saveMe)
        {
            MRUDatabase.Insert(saveMe);
            return saveMe;
        }
        public T Update(T updateMe)
        {
            MRUDatabase.Update(updateMe);
            return updateMe;
        }
        public T GetById(int id)
        {
            return MRUDatabase.SingleById<T>(id);
        }
        public bool Delete(int id)
        {
            T deleteMe = MRUDatabase.SingleById<T>(id);
            MRUDatabase.Delete(deleteMe);
            return true;
        }
    }
}
