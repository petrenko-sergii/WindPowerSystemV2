using System.Collections.Generic;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;

namespace WindPowerSystemV2.Services.Interfaces
{
	public interface IFarmService
	{
		IEnumerable<FarmDto> GetAllFarms();
		FarmDto GetFarmById(int id);
		FarmDto Create(FarmDto dto);
		void Update(int id, UpdateFarmDto dto);
		void Remove(int id);
	}
}
