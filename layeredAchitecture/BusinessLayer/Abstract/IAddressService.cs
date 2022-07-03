using ETicaret.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BusinessLayer.Abstract
{
    public interface IAddressService
    {
        Task<Address> Create(Address address);
        Task Delete(Address address);
        Task<List<Address>> GetAll();
        Task<Address> GetElemanById(int id);
        Task<Address> Update(Address address);
    }
}
