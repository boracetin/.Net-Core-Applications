using ETicaret.BusinessLayer.Abstract;
using ETicaret.DataAccessLayer.Abstract;
using ETicaret.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderRepository _orderRepository;
        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<Order> Create(Order order)
        {
            return await _orderRepository.Create(order);
        }

        public async Task  Delete(Order order)
        {
            await _orderRepository.Delete(order);
        }

        public async Task<List<Order>> GetAll()
        {
            return await _orderRepository.GetAll();
        }

        public async Task<Order> GetElemanById(int id)
        {
            return await _orderRepository.GetElemanById(id);
        }

        public async Task<Order> Update(Order order)
        {
            return await _orderRepository.Update(order);
        }
    }
}
