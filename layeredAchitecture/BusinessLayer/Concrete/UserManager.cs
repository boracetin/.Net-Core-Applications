using ETicaret.BusinessLayer.Abstract;
using ETicaret.DataAccessLayer.Abstract;
using ETicaret.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<User> Create(User user)
        {
            return await _userRepository.Create(user);
            
        }

        public async Task Delete(User user)
        {
            await _userRepository.Delete(user);
        }

        public async Task<List<User>> GetAll()
        {
            return await _userRepository.GetAll();
        }

        public async  Task<User> GetElemanById(int id)
        {
            return await _userRepository.GetElemanById(id);
        }

        public async Task<User> Update(User user)
        {
            return await _userRepository.Update(user);
           
        }
    }
}
