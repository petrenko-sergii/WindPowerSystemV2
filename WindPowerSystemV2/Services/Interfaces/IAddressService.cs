using System.Collections.Generic;
using WindPowerSystemV2.DTOs.AddressDtos;

namespace WindPowerSystemV2.Services.Interfaces
{
	public interface IAddressService
	{
		IEnumerable<AddressDto> GetAllAddresses();
		AddressDto GetAddressById(int id);
		AddressDto Create(AddressDto dto);
		void Update(int id, AddressDto dto);
		void Remove(int id);
	}
}
