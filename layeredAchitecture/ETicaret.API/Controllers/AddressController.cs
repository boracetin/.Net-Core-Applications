using ETicaret.BusinessLayer.Abstract;
using ETicaret.DataLayer.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.API.Controllers
{
    [Route("/api/Address")]
    [ApiController]
    public class AddressController:ControllerBase
    {
        private IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Address>>> GetAll()
        {
            await _addressService.GetAll();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> GetById(int id)
        {
            Address address =await _addressService.GetElemanById(id);
            if (address != null)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Address address)
        {

            Address addressCheck = await _addressService.GetElemanById(address.Id); 
            if (addressCheck != null)
            {
                await _addressService.Delete(address);
                return Ok();
            }

            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Post(Address address)
        {
            Address addressCheck = await _addressService.GetElemanById(address.Id);
            if (addressCheck !=null)
            {
                await _addressService.Create(address);
                return Ok();
            }
            return BadRequest();

        }

        [HttpPut]
        public async Task<IActionResult> Put(Address address)
        {
            Address addressCheck = await _addressService.GetElemanById(address.Id);
            if (addressCheck != null)
            {
                await _addressService.Update(address);
                return Ok( );  
            }
            return BadRequest();
        }

    }
}
