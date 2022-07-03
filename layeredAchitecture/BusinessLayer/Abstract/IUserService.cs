using ETicaret.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BusinessLayer.Abstract
{
    public interface IUserService
    {
        Task<User> Create(User user);
        Task Delete(User user);
        Task<List<User>> GetAll();
        Task<User> GetElemanById(int id);
        Task<User> Update(User user);
    }
}
