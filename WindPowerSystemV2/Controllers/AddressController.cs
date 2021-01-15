using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WindPowerSystemV2.DTOs.AddressDtos;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Controllers
{
    [Route("api/Address")]
    public class AddressController
	{
		private readonly IAddressService _addressService;

		public AddressController( IAddressService addressService)
		{
			_addressService = addressService;
		}

		// GET: api/Address
		[HttpGet]
		public ActionResult<IEnumerable<AddressDto>> Get()
		{
			var addressDtos = _addressService.GetAllAddresses();

			return addressDtos.ToList();
		}

		//GET: api/Address/5
		[HttpGet("{id}")]
		public ActionResult<AddressDto> Get(int id)
		{
			return _addressService.GetAddressById(id);
		}

		//POST: api/Address
		[HttpPost]
		public ActionResult<AddressDto> Post([FromBody] AddressDto dto)
		{
			return _addressService.Create(dto);
		}

		// PUT: api/Address/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] AddressDto dto)
		{
			_addressService.Update(id, dto);
		}

		// DELETE: api/Address/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_addressService.Remove(id);
		}
	}
}