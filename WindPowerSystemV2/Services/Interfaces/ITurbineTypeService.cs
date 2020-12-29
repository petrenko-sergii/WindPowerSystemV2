using NHibernate;
using System.Collections.Generic;
using WindPowerSystemV2.DTOs;

namespace WindPowerSystemV2.Services.Interfaces
{
	public interface ITurbineTypeService
	{
		IEnumerable<TurbineTypeDto> GetAllTurbineTypes(ISession session);
		TurbineTypeDto GetTurbineTypeById(int id, ISession session);
		void UpdateTurbineType(int id, TurbineTypeDto dto, ISession session);
		TurbineTypeDto Create(TurbineTypeDto dto, ISession session);
	}
}
