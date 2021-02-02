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
		private readonly ITurbineTypeRepository _turbineTypeRepository;
		private readonly IOperatorRepository _operatorRepository;
		private readonly IFarmRepository _farmRepository;
		private readonly IAddressRepository _addressRepository;
		private readonly IAppImageRepository _appImageRepository;

		private readonly string _exceptionMsgCostCanNotBeZeroOrNegative = "Cost can not be zero or negative.";

		public TurbineService(ITurbineRepository turbineRepository, 
								ITurbineTypeRepository turbineTypeRepository, 
								IOperatorRepository operatorRepository,
								IFarmRepository farmRepository,
								IAddressRepository addressRepository,
								IAppImageRepository appImageRepository)
		{
			_turbineRepository = turbineRepository;
			_turbineTypeRepository = turbineTypeRepository;
			_operatorRepository = operatorRepository;
			_farmRepository = farmRepository;
			_addressRepository = addressRepository;
			_appImageRepository = appImageRepository;
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

			if (dto.ProdMW > 0)
				turbine.ProdMW = dto.ProdMW;

			if (dto.Cost > 0 )
				turbine.Cost = dto.Cost;

			if (dto.InstallCost > 0)
				turbine.InstallCost = dto.InstallCost;

			if (dto.InstallDate != DateTime.MinValue)
				turbine.InstallDate = dto.InstallDate;

			if (dto.LastServDate != DateTime.MinValue)
				turbine.LastServDate = dto.LastServDate;

			if (dto.NextServDate != DateTime.MinValue)
				turbine.NextServDate = dto.NextServDate;

			if (dto.LastYearServDate != DateTime.MinValue)
				turbine.LastYearServDate = dto.LastYearServDate;

			if (dto.NextYearServDate != DateTime.MinValue)
				turbine.NextYearServDate = dto.NextYearServDate;

			if (dto.TurbineTypeId != turbine.TurbineType.Id)
			{
				var turbineType = _turbineTypeRepository.FindById(dto.TurbineTypeId);

				if(turbineType != null)
					turbine.TurbineType = turbineType;
			}

			if (dto.OperatorId != turbine.Operator.Id)
			{
				var operatorDbItem = _operatorRepository.FindById(dto.OperatorId);

				if (operatorDbItem != null)
					turbine.Operator = operatorDbItem;
			}

			if (turbine.Farm != null && dto.FarmId != turbine.Farm.Id)
			{
				var farm = _farmRepository.FindById(dto.FarmId);

				if (farm != null)
					turbine.Farm = farm;
			}

			if (dto.AddressId != turbine.Address.Id)
			{
				var address = _addressRepository.FindById(dto.AddressId);

				if (address != null)
					turbine.Address = address;
			}

			if (turbine.Image != null && dto.ImageId != turbine.Image.Id)
			{
				var image = _appImageRepository.FindById(dto.ImageId);

				if (image != null)
					turbine.Image = image;
			}

			_turbineRepository.Update(turbine);
		}

		public void Remove(int id)
		{
			var turbine = _turbineRepository.FindById(id);

			if (turbine == null)
				throw new Exception("Turbine was not found");

			_turbineRepository.Remove(turbine);
		}

		public void ValidatePostModel(TurbineDto dto)
		{
			ValidateCost(dto.Cost);
			ValidateCost(dto.InstallCost);

			if (dto.InstallDate == DateTime.MinValue)
				dto.InstallDate = DateTime.Now;

			if (dto.LastServDate == DateTime.MinValue)
				dto.LastServDate = DateTime.Now;

			if (dto.NextServDate == DateTime.MinValue)
				dto.NextServDate = dto.LastServDate.AddMonths(6);

			if (dto.LastYearServDate == DateTime.MinValue)
				dto.LastYearServDate = dto.LastServDate;

			if (dto.NextYearServDate == DateTime.MinValue)
				dto.NextYearServDate = dto.LastYearServDate.AddYears(1);
		}

		private void ValidateCost(decimal price)
		{
			if (price <= 0)
				throw new Exception(_exceptionMsgCostCanNotBeZeroOrNegative);
		}
	}
}
