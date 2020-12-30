using NHibernate;
using System.Collections.Generic;
using WindPowerSystemV2.DTOs;

namespace WindPowerSystemV2.Services.Interfaces
{
	public interface ITurbineTypeService
	{
		IEnumerable<TurbineTypeDto> GetAllTurbineTypes(ISession session);
		TurbineTypeDto GetTurbineTypeById(int id, ISession session);
		void Update(int id, TurbineTypeDto dto, ISession session);
		TurbineTypeDto Create(TurbineTypeDto dto, ISession session);
		void Remove(int id, ISession session);
	}
}
