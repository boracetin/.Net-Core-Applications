using ETicaret.DataAccessLayer.Abstract;
using ETicaret.DataLayer.Model;

namespace ETicaret.DataAccessLayer.EfCore
{
    public class ProductRepository:EfCoreGenericRepository<Product,ETicaretContext>,IProductRepository
    {

    }
}
