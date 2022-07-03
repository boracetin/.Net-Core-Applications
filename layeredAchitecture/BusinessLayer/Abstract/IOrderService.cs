using ETicaret.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BusinessLayer.Abstract
{
    public interface IOrderService
    {
        Task<Order> Create(Order order);
        Task Delete(Order order);
        Task<List<Order>> GetAll();
        Task<Order> GetElemanById(int id);
        Task<Order> Update(Order order);
    }
}
