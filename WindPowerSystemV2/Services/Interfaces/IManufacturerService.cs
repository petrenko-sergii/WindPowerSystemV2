using System.Collections.Generic;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;

namespace WindPowerSystemV2.Services.Interfaces
{
	public interface IManufacturerService
	{
		IEnumerable<ManufacturerDto> GetAllManufacturers();
		ManufacturerDto GetManufacturerById(int id);
		ManufacturerDto Create(ManufacturerDto dto);
		void Update(int id, UpdateManufacturerDto dto);
		void Remove(int id);
	}
}
