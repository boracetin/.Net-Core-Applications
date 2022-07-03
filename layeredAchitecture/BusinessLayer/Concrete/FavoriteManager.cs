using ETicaret.BusinessLayer.Abstract;
using ETicaret.DataAccessLayer.Abstract;
using ETicaret.DataAccessLayer.EfCore;
using ETicaret.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BusinessLayer.Concrete
{
    public class FavoriteManager:IFavoriteService
    {
        private IFavoriteRepository _favoriteRepository;
        public FavoriteManager(IFavoriteRepository favoriteRepository)
        {
            _favoriteRepository = favoriteRepository;
        }

        public async Task<Favorite> Create(Favorite favorite)
        {
            return await _favoriteRepository.Create(favorite);
        }

        public async Task Delete(Favorite favorite)
        {
            await _favoriteRepository.Delete(favorite);
        }

        public async Task<List<Favorite>> GetAll()
        {
            return await _favoriteRepository.GetAll();
        }

        public async Task<Favorite> GetElemanById(int id)
        {
            return await _favoriteRepository.GetElemanById(id);
        }

        public async Task<Favorite> Update(Favorite favorite)
        {
            return await _favoriteRepository.Update(favorite);
        }
    }
}
