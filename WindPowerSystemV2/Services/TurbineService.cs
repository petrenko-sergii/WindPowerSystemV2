using System;
using System.Collections.Generic;
using System.Linq;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;
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

		public IEnumerable<TurbineDto> GetAllTurbines()
		{
			var turbines = _turbineRepository.GetAll();

			var turbineDtoList = new List<TurbineDto>();

			turbines.ToList().ForEach(t =>
				turbineDtoList.Add(Mapper.Map<Turbine, TurbineDto>(t)));

			return turbineDtoList.OrderBy(t => t.Id);
		}

		public TurbineDto GetTurbineById(int id)
		{
			var turbine = _turbineRepository.FindById(id);

			if (turbine == null)
				throw new Exception("Turbine was not found");

			return Mapper.Map<Turbine, TurbineDto>(turbine);
		}

		public TurbineDto Create(TurbineDto dto)
		{
			var turbine = Mapper.Map<TurbineDto, Turbine>(dto);

			_turbineRepository.Create(turbine);

			return Mapper.Map<Turbine, TurbineDto>(_turbineRepository.FindById(turbine.Id));
		}

		public void Update(int id, UpdateTurbineDto dto)
		{
			var turbine = _turbineRepository.FindById(id);

			if (turbine == null)
				throw new Exception("Turbine was not found");

			if (dto.SerialNum != null)
				turbine.SerialNum = dto.SerialNum;

			if (dto.ProdMW != 0)
				turbine.ProdMW = dto.ProdMW;

			_turbineRepository.Update(turbine);
		}

		public void Remove(int id)
		{
			var turbine = _turbineRepository.FindById(id);

			if (turbine == null)
				throw new Exception("Turbine was not found");

			_turbineRepository.Remove(turbine);
		}
	}
}
