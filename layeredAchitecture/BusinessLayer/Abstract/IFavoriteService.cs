using ETicaret.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BusinessLayer.Abstract
{

    public interface IFavoriteService
    {
        Task<Favorite> Create(Favorite favorite);
        Task Delete(Favorite favorite);
        Task<List<Favorite>> GetAll();
        Task<Favorite> GetElemanById(int id);
        Task<Favorite> Update(Favorite favorite);
    }

}
