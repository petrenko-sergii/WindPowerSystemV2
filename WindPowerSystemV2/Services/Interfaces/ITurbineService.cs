using NHibernate;
using System.Collections.Generic;
using WindPowerSystemV2.DTOs;

namespace WindPowerSystemV2.Services.Interfaces
{
	public interface ITurbineService
	{
		IEnumerable<TurbineDto> GetAllTurbines(ISession session);
		TurbineDto GetTurbineById(int id, ISession session);
		void Update(int id, TurbineDto dto, ISession session);
		TurbineDto Create(TurbineDto dto, ISession session);
		void Remove(int id, ISession session);
	}
}
