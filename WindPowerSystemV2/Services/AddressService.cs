using System;
using System.Collections.Generic;
using System.Linq;
using WindPowerSystemV2.DTOs.AddressDtos;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models.AddressModels;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Services
{
	public class AddressService : BaseService, IAddressService
	{
		private readonly IAddressRepository _addressRepository;

		public AddressService(IAddressRepository addressRepository)
		{
			_addressRepository = addressRepository;
		}

		public IEnumerable<AddressDto> GetAllAddresses()
		{
			var addresss = _addressRepository.GetAll();

			var addressDtoList = new List<AddressDto>();

			addresss.ToList().ForEach(t =>
				addressDtoList.Add(Mapper.Map<Address, AddressDto>(t)));

			return addressDtoList.OrderBy(t => t.Id);
		}

		public AddressDto GetAddressById(int id)
		{
			var address = _addressRepository.FindById(id);

			if (address == null)
				throw new Exception("Address was not found");

			return Mapper.Map<Address, AddressDto>(address);
		}

		public AddressDto Create(AddressDto dto)
		{
			return new AddressDto(); //TODO: will be implemented
		}

		public void Update(int id, AddressDto dto)
		{
			//TODO: will be implemented
		}

		public void Remove(int id)
		{
			//TODO: will be implemented
		}
	}
}
