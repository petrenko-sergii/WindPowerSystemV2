using System.Collections.Generic;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;

namespace WindPowerSystemV2.Services.Interfaces
{
	public interface IOperatorService
	{
		IEnumerable<OperatorDto> GetAllOperators();
		OperatorDto GetOperatorById(int id);
		OperatorDto Create(OperatorDto dto);
		void Update(int id, UpdateOperatorDto dto);
		void Remove(int id);
	}
}
