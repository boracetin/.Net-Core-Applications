using ETicaret.DataAccessLayer.Abstract;
using ETicaret.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.DataAccessLayer.EfCore
{
    public class FavoriteRepository:EfCoreGenericRepository<Favorite,ETicaretContext>,IFavoriteRepository
    {
    }
}
