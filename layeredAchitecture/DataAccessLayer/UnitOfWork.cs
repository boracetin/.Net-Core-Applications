using ETicaret.DataAccessLayer.Abstract;
using ETicaret.DataAccessLayer.EfCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer
{
   // bunu generic yap tamamini tek bir yerden
    public class UnitOfWork : IUnitOfWork
    {

        private ETicaretContext _eTicaretContext;
        public UnitOfWork(ETicaretContext eTicaretContext)
        {
            _eTicaretContext = eTicaretContext;
            OderRepository = new OrderRepository();
            ProductRepository = new ProductRepository();
            AddressRepository = new AddressRepository();
            UserRepository = new UserRepository();
            FavoriteRepository = new FavoriteRepository();
            
        }

        public IProductRepository ProductRepository { get; private set; }

        public IUserRepository UserRepository { get; private set; }

        public IFavoriteRepository FavoriteRepository { get; private set; }

        public IAddressRepository AddressRepository { get; private set; }
        public IOrderRepository OderRepository { get; private set; }

        public  Task<int> Complete()  
        {
            return _eTicaretContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _eTicaretContext.Dispose();
        }
    }
}
