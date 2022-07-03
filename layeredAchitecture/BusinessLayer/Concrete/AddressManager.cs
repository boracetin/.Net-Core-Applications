using ETicaret.BusinessLayer.Abstract;
using ETicaret.DataAccessLayer.Abstract;
using ETicaret.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        private IAddressRepository _addressRepository;
        public   AddressManager(IAddressRepository addressRepository)
        {
             _addressRepository = addressRepository;
        }
        public async Task<Address> Create(Address address)
        {
            return await _addressRepository.Create(address);
        }

        public async Task Delete(Address address)
        {
            await _addressRepository.Delete(address);
        }

        public async Task<List<Address>> GetAll()
        {
            return await  _addressRepository.GetAll();
        }

        public async Task<Address> GetElemanById(int id)
        {
            return await _addressRepository.GetElemanById(id);
        }

        public async Task<Address> Update(Address address)
        {
            return await _addressRepository.Update(address);
        }
    }
}
