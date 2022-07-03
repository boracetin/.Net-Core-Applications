using ETicaret.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer
{
    public interface IUnitOfWork:IDisposable
    {
        IProductRepository ProductRepository { get; }
        IUserRepository UserRepository { get; }
        IFavoriteRepository FavoriteRepository { get; }
        IAddressRepository AddressRepository { get; }
        IOrderRepository OderRepository { get; }
        Task<int> Complete();
    }
}
