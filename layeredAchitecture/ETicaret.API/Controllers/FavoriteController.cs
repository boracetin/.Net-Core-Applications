using ETicaret.BusinessLayer.Abstract;
using ETicaret.DataLayer.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.API.Controllers
{
    [Route("/api/favorite")]
    [ApiController]
    public class FavoriteController:ControllerBase
    {
        private IFavoriteService _favoriteService;

        public FavoriteController(IFavoriteService favoriteService)
        {
            _favoriteService = favoriteService;
        }
        [HttpGet]
        public async Task<List<Favorite>> GetAll()
        {
            return await _favoriteService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Favorite> GetById(int id)
        {
            return await _favoriteService.GetElemanById(id);
        }

        [HttpDelete]
        public async Task Delete(Favorite favorite)
        {
            await _favoriteService.Delete(favorite);
        }

        [HttpPost]
        public async Task<Favorite> Post(Favorite favorite)
        {
            return await _favoriteService.Create(favorite);

        }

        [HttpPut]
        public async Task<Favorite> Put(Favorite favorite)
        {
            return await _favoriteService.Update(favorite);
        }






    }
}
