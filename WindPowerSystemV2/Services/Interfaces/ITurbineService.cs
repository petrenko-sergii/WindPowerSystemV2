using System.Collections.Generic;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;

namespace WindPowerSystemV2.Services.Interfaces
{
	public interface ITurbineService
	{
		IEnumerable<TurbineDto> GetAllTurbines();
		TurbineDto GetTurbineById(int id);
		TurbineDto Create(TurbineDto dto);
		void Update(int id, UpdateTurbineDto dto);
		void Remove(int id);
	}
}
