using System.Collections.Generic;
using WindPowerSystemV2.DTOs;

namespace WindPowerSystemV2.Services.Interfaces
{
	public interface ITurbineService
	{
		IEnumerable<TurbineDto> GetAllTurbines();
		TurbineDto GetTurbineById(int id);
		TurbineDto Create(TurbineDto dto);
		void Update(int id, TurbineDto dto);
		void Remove(int id);
	}
}
