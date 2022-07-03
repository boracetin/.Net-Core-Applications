using System.Collections.Generic;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Abstract
{
    public interface IRepository<T> 
        where T: class
    {
        Task<T> Create(T t);
        Task Delete(T t);
        Task<List<T>> GetAll();
        Task<T> GetElemanById(int id);
        Task<T> Update(T t);

    }
}
