﻿using System;
using System.Collections.Generic;
using System.Linq;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Services
{
	public class TurbineTypeService : BaseService, ITurbineTypeService
	{
		private readonly ITurbineTypeRepository _turbineTypeRepository;
		private readonly IManufacturerRepository _manufacturerRepository;

		public TurbineTypeService(ITurbineTypeRepository turbineTypeRepository, IManufacturerRepository manufacturerRepository)
		{
			_turbineTypeRepository = turbineTypeRepository;
			_manufacturerRepository = manufacturerRepository;
		}

		public IEnumerable<TurbineTypeDto> GetAllTurbineTypes()
		{
			var turbineTypes = _turbineTypeRepository.GetAll();

			var turbineTypeDtoList = new List<TurbineTypeDto>();

			turbineTypes.ToList().ForEach(t =>
				turbineTypeDtoList.Add(Mapper.Map<TurbineType, TurbineTypeDto>(t)));

			return turbineTypeDtoList.OrderBy(t=>t.Id);
		}

		public TurbineTypeDto GetTurbineTypeById(int id)
		{
			var turbineType = _turbineTypeRepository.FindById(id);

			if (turbineType == null)
				throw new Exception("TurbineType was not found");

			return Mapper.Map<TurbineType, TurbineTypeDto>(turbineType);
		}

		public TurbineTypeDto Create(TurbineTypeDto dto)
		{
			var turbineType = Mapper.Map<TurbineTypeDto, TurbineType>(dto);

			_turbineTypeRepository.Create(turbineType);

			return Mapper.Map<TurbineType, TurbineTypeDto>(_turbineTypeRepository.FindById(turbineType.Id));
		}

		public void Update(int id, UpdateTurbineTypeDto dto)
		{
			var turbineType = _turbineTypeRepository.FindById(id);

			if (turbineType == null)
				throw new Exception("TurbineType was not found");

			if (dto.Model != null)
				turbineType.Model = dto.Model;

			if (dto.Capacity != 0)
				turbineType.Capacity = dto.Capacity;

			if (dto.TowerHeight != 0)
				turbineType.TowerHeight = dto.TowerHeight;

			if (dto.RotorDiameter != 0)
				turbineType.RotorDiameter = dto.RotorDiameter;

			if (dto.SweptArea != 0)
				turbineType.SweptArea = dto.SweptArea;

			if (dto.ManufacturerId != turbineType.Manufacturer.Id)
			{
				var manufacturer = _manufacturerRepository.FindById(dto.ManufacturerId);

				if (manufacturer != null)
					turbineType.Manufacturer = manufacturer;
			}

			_turbineTypeRepository.Update(turbineType);
		}

		public void Remove(int id)
		{
			var turbineType = _turbineTypeRepository.FindById(id);

			if (turbineType == null)
				throw new Exception("TurbineType was not found");

			_turbineTypeRepository.Remove(turbineType);
		}
	}
}
