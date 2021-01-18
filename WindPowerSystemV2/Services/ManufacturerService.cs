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
	public class ManufacturerService : BaseService, IManufacturerService
	{
		private readonly IManufacturerRepository _manufacturerRepository;
		private readonly IAddressRepository _addressRepository;

		public ManufacturerService(IManufacturerRepository operatorRepository, IAddressRepository addressRepository)
		{
			_manufacturerRepository = operatorRepository;
			_addressRepository = addressRepository;
		}

		public IEnumerable<ManufacturerDto> GetAllManufacturers()
		{
			var manufacturers = _manufacturerRepository.GetAll();

			var operatorDtoList = new List<ManufacturerDto>();

			manufacturers.ToList().ForEach(t =>
				operatorDtoList.Add(Mapper.Map<Manufacturer, ManufacturerDto>(t)));

			return operatorDtoList.OrderBy(t => t.Id);
		}

		public ManufacturerDto GetManufacturerById(int id)
		{
			var manufacturer = _manufacturerRepository.FindById(id);

			if (manufacturer == null)
				throw new Exception("Manufacturer was not found");

			return Mapper.Map<Manufacturer, ManufacturerDto>(manufacturer);
		}

		public ManufacturerDto Create(ManufacturerDto dto)
		{
			var manufacturer = Mapper.Map<ManufacturerDto, Manufacturer>(dto);

			_manufacturerRepository.Create(manufacturer);

			return Mapper.Map<Manufacturer, ManufacturerDto>(_manufacturerRepository.FindById(manufacturer.Id));
		}

		public void Update(int id, UpdateManufacturerDto dto)
		{
			var operatorDb = _manufacturerRepository.FindById(id);

			if (operatorDb == null)
				throw new Exception("Manufacturer was not found");

			if (dto.Name != null)
				operatorDb.Name = dto.Name;

			if (dto.Email != null)
				operatorDb.Email = dto.Email;

			if (dto.Phone != null)
				operatorDb.Phone = dto.Phone;

			if (dto.Website != null)
				operatorDb.Website = dto.Website;

			if (dto.AddressId != operatorDb.Address.Id)
			{
				var address = _addressRepository.FindById(dto.AddressId);

				if (address != null)
					operatorDb.Address = address;
			}

			_manufacturerRepository.Update(operatorDb);
		}

		public void Remove(int id)
		{
			var operatorDb = _manufacturerRepository.FindById(id);

			if (operatorDb == null)
				throw new Exception("Manufacturer was not found");

			_manufacturerRepository.Remove(operatorDb);
		}
	}
}
