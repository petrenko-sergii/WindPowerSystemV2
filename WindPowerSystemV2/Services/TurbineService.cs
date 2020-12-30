using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Services
{
	public class TurbineService : BaseService, ITurbineService
	{
		private readonly ITurbineRepository _turbineRepository;

		public TurbineService(ITurbineRepository turbineRepository)
		{
			this._turbineRepository = turbineRepository;
		}

		public IEnumerable<TurbineDto> GetAllTurbines(ISession session)
		{
			var turbines = _turbineRepository.GetAll(session);

			var turbineDtoList = new List<TurbineDto>();

			turbines.ToList().ForEach(t =>
				turbineDtoList.Add(Mapper.Map<Turbine, TurbineDto>(t)));

			return turbineDtoList;
		}

		public TurbineDto GetTurbineById(int id, ISession session)
		{
			var turbine = _turbineRepository.FindById(id, session);

			if (turbine == null)
				throw new Exception("TurbineType was not found");

			return Mapper.Map<Turbine, TurbineDto>(turbine);
		}

		public void Update(int id, TurbineDto dto, ISession session)
		{
			var turbine = _turbineRepository.FindById(id, session);

			if (turbine == null)
				throw new Exception("Turbine was not found");

			if (dto.SerialNum != null)
				turbine.SerialNum = dto.SerialNum;

			if (dto.ProdMW != 0)
				turbine.ProdMW = dto.ProdMW;

			_turbineRepository.Update(turbine, session);
		}


		public TurbineDto Create(TurbineDto dto, ISession session)
		{
			var turbine = Mapper.Map<TurbineDto, Turbine>(dto);

			_turbineRepository.Create(turbine, session);

			return Mapper.Map<Turbine, TurbineDto>(_turbineRepository.FindById(turbine.Id, session));
		}

		public void Remove(int id, ISession session)
		{
			var turbine = _turbineRepository.FindById(id, session);

			if (turbine == null)
				throw new Exception("Turbine was not found");

			_turbineRepository.Remove(turbine, session);
		}
	}
}
