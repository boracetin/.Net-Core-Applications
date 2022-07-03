using ETicaret.BusinessLayer.Abstract;
using ETicaret.DataAccessLayer.Abstract;
using ETicaret.DataLayer.Model;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.API
{
    [Route("/api/product")]
    [ApiController]
    //IACTIONRESULT ILE HATALARIN TAMAMINI KONTROL ET.
    //UI TARAFINDA KARSINA NE GIBI HATALAR CIKABILIR GOOGLEDAN BAK
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<List<Product>> GetAll()
        {
            return await _productService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Product> GetById(int id)
        {
            return await  _productService.GetElemanById(id);
        }

        [HttpDelete]
        public async Task Delete(Product product)
        {
            await _productService.Delete(product);
        }

        [HttpPost]
        public async Task<Product> Post(Product product)
        {
            return await _productService.Create(product);
            
        }

        [HttpPut]
        public async Task<Product> Put(Product product)
        {
            return await _productService.Update(product);
        }
        

    }
}
