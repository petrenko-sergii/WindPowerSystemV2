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
	public class TurbineTypeService : BaseService, ITurbineTypeService
	{
		private readonly ITurbineTypeRepository _turbineTypeRepository;

		public TurbineTypeService(ITurbineTypeRepository turbineTypeRepository)
		{
			this._turbineTypeRepository = turbineTypeRepository;
		}

		public IEnumerable<TurbineTypeDto> GetAllTurbineTypes(ISession session)
		{
			var turbineTypes = _turbineTypeRepository.GetAll(session);

			var turbineTypeDtoList = new List<TurbineTypeDto>();

			turbineTypes.ToList().ForEach(t =>
				turbineTypeDtoList.Add(Mapper.Map<TurbineType, TurbineTypeDto>(t)));

			return turbineTypeDtoList;
		}

		public TurbineTypeDto GetTurbineTypeById(int id, ISession session)
		{
			var turbineType = _turbineTypeRepository.FindById(id, session);

			if (turbineType == null)
				throw new Exception("TurbineType was not found");

			return Mapper.Map<TurbineType, TurbineTypeDto>(turbineType);
		}

		public void UpdateTurbineType(int id, TurbineTypeDto dto, ISession session)
		{
			var turbineType = _turbineTypeRepository.FindById(id, session);

			if (turbineType == null)
				throw new Exception("TurbineType was not found");

			if (dto.Model != null)
				turbineType.Model = dto.Model;

			if (dto.Capacity != 0)
				turbineType.Capacity = dto.Capacity;

			if(dto.TowerHeight != 0)
				turbineType.TowerHeight = dto.TowerHeight;

			if (dto.RotorDiameter != 0)
				turbineType.RotorDiameter = dto.RotorDiameter;

			if (dto.SweptArea != 0)
				turbineType.SweptArea = dto.SweptArea;

			_turbineTypeRepository.Update(turbineType, session);
		}


		public TurbineTypeDto Create(TurbineTypeDto dto, ISession session)
		{
			var turbineType = Mapper.Map<TurbineTypeDto, TurbineType>(dto);

			_turbineTypeRepository.Create(turbineType, session);

			return Mapper.Map<TurbineType, TurbineTypeDto>(_turbineTypeRepository.FindById(turbineType.Id, session));
		}

		public void Remove(int id, ISession session)
		{
			var turbineType = _turbineTypeRepository.FindById(id, session);

			if (turbineType == null)
				throw new Exception("TurbineType was not found");

			_turbineTypeRepository.Remove(turbineType, session);
		}
	}
}
