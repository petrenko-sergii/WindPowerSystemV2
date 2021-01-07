using System.Collections.Generic;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;

namespace WindPowerSystemV2.Services.Interfaces
{
	public interface ITurbineTypeService
	{
		IEnumerable<TurbineTypeDto> GetAllTurbineTypes();
		TurbineTypeDto GetTurbineTypeById(int id);
		TurbineTypeDto Create(TurbineTypeDto dto);
		void Update(int id, UpdateTurbineTypeDto dto);
		void Remove(int id);
	}
}
