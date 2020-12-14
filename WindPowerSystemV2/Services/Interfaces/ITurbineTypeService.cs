using System.Collections.Generic;
using WindPowerSystemV2.DTOs;

namespace WindPowerSystemV2.Services.Interfaces
{
	public interface ITurbineTypeService
	{
		IEnumerable<TurbineTypeDto> GetAllTurbineTypes();
		TurbineTypeDto GetTurbineTypeById(int id);
		//void UpdateTurbineType(int id, TurbineTypeDto dto);
		TurbineTypeDto Create(TurbineTypeDto dto);
	}
}
