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
	public class FarmService : BaseService, IFarmService
	{
		private readonly IFarmRepository _farmRepository;
		private readonly IAddressRepository _addressRepository;
		private readonly IAppImageRepository _appImageRepository;

		public FarmService(IFarmRepository farmRepository, IAddressRepository addressRepository, IAppImageRepository appImageRepository)
		{
			_farmRepository = farmRepository;
			_addressRepository = addressRepository;
			_appImageRepository = appImageRepository;
		}

		public IEnumerable<FarmDto> GetAllFarms()
		{
			var farms = _farmRepository.GetAll();
			var farmDtoList = new List<FarmDto>();

			farms.ToList().ForEach(t =>
				farmDtoList.Add(Mapper.Map<Farm, FarmDto>(t)));

			return farmDtoList.OrderBy(t => t.Id);
		}

		public FarmDto GetFarmById(int id)
		{
			var farm = _farmRepository.FindById(id);

			if (farm == null)
				throw new Exception("Farm was not found");

			return Mapper.Map<Farm, FarmDto>(farm);
		}

		public FarmDto Create(FarmDto dto)
		{
			var farm = Mapper.Map<FarmDto, Farm>(dto);

			_farmRepository.Create(farm);

			return Mapper.Map<Farm, FarmDto>(_farmRepository.FindById(farm.Id));
		}

		public void Update(int id, UpdateFarmDto dto)
		{
			var farm = _farmRepository.FindById(id);

			if (farm == null)
				throw new Exception("Farm was not found");

			if (dto.Name != null)
				farm.Name = dto.Name;

			if (dto.AddressId != farm.Address.Id)
			{
				var address = _addressRepository.FindById(dto.AddressId);

				if (address != null)
					farm.Address = address;
			}

			if (dto.ImageId != farm.Image.Id)
			{
				var image = _appImageRepository.FindById(dto.ImageId);

				if (image != null)
					farm.Image = image;
			}

			_farmRepository.Update(farm);
		}

		public void Remove(int id)
		{
			var farm = _farmRepository.FindById(id);

			if (farm == null)
				throw new Exception("Farm was not found");

			_farmRepository.Remove(farm);
		}
	}
}
