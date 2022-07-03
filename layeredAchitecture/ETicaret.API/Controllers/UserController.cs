using ETicaret.BusinessLayer.Abstract;
using ETicaret.DataLayer.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.API.Controllers
{
    [Route("/api/user")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService=userService;
        }

        [HttpGet]
        public async Task<List<User>> GetAll()
        {
            return await _userService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<User> GetById(int id)
        {
            return await _userService.GetElemanById(id);
        }

        [HttpDelete]
        public async Task Delete([FromBody] User user)
        {
            await _userService.Delete(user);
        }

        [HttpPost]
        public async Task<User> Post([FromBody]User user)
        {
            return await _userService.Create(user);


        }
        [HttpPut]
        public async Task<User> Put([FromBody] User user)
        {
            return await _userService.Update(user);
        }
    }
}
