using ETicaret.BusinessLayer.Abstract;
using ETicaret.DataLayer.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.API.Controllers
{
    [Route("/api/order")]
    [Controller]
    
    public class OrderController:ControllerBase
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;

        }

        [HttpGet]
        public async Task<List<Order>> GetAll()  //sepetim kismi kullanci sepetime bastigi anda veribanindan sepetteki urunler geliyor
        {
            return await _orderService.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Order> GetById(int id)
        {
            return await _orderService.GetElemanById(id);
        }

        [HttpDelete]   //sepetten istedigi bir urunu siliyor 
        public async Task Delete(Order order)
        {
            await _orderService.Delete(order);
            
        }

        [HttpPost]  //sepete ekleme yapabiliyor
        public async Task<Order> Post(Order order)
        {
            return await _orderService.Create(order);

        }

        [HttpPut]
        public async Task<Order> Put(Order order)
        {
            return await _orderService.Update(order);
        }
    }
}
