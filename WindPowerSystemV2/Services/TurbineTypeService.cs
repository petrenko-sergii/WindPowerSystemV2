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

		public IEnumerable<TurbineTypeDto> GetAllTurbineTypes()
		{
			var turbineTypes = _turbineTypeRepository.GetAll();

			var turbineTypeDtoList = new List<TurbineTypeDto>();

			turbineTypes.ToList().ForEach(t =>
				turbineTypeDtoList.Add(Mapper.Map<TurbineType, TurbineTypeDto>(t)));

			return turbineTypeDtoList;
		}

		public TurbineTypeDto GetTurbineTypeById(int id)
		{
			var turbineType = _turbineTypeRepository.FindById(id);

			if (turbineType == null)
				throw new Exception("TurbineType was not found");

			return Mapper.Map<TurbineType, TurbineTypeDto>(turbineType);
		}

		public void UpdateTurbineType(int id, TurbineTypeDto dto)
		{
			var turbineType = _turbineTypeRepository.FindById(id);

			if (turbineType == null)
				throw new Exception("TurbineType was not found");

			if (dto.Model != null)
				turbineType.Model = dto.Model;

			if (dto.Capacity != 0)
				turbineType.Capacity = dto.Capacity;

			_turbineTypeRepository.Update(turbineType);
		}


		public TurbineTypeDto Create(TurbineTypeDto dto)
		{
			var turbineType = Mapper.Map<TurbineTypeDto, TurbineType>(dto);

			_turbineTypeRepository.Create(turbineType);

			return Mapper.Map<TurbineType, TurbineTypeDto>(_turbineTypeRepository.FindById(turbineType.Id));
		}
	}
}
