using ETicaret.DataAccessLayer.Abstract;
using ETicaret.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BusinessLayer.Abstract
{
    public interface IProductService
    {
        Task<Product> Create(Product product);
        Task Delete(Product product);
        Task<List<Product>> GetAll();
        Task<Product> GetElemanById(int id);
        Task<Product> Update(Product product);
    }
}
