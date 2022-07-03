using ETicaret.BusinessLayer.Abstract;
using ETicaret.DataAccessLayer.Abstract;
using ETicaret.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Product> Create(Product product)
        {
            return await _productRepository.Create(product);
        }

        public async Task Delete(Product product)
        {
            await _productRepository.Delete(product);
        }

        public async Task<List<Product>> GetAll()
        {
            return await _productRepository.GetAll();
        }

        public async Task<Product> GetElemanById(int id)
        {
            return await _productRepository.GetElemanById(id);
        }

        public async Task<Product> Update(Product product)
        {
            return await _productRepository.Update(product);
        }
    }
}
