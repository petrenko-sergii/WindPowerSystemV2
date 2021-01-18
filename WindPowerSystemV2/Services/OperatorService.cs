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
	public class OperatorService : BaseService, IOperatorService
	{
		private readonly IOperatorRepository _operatorRepository;
		private readonly IAddressRepository _addressRepository;

		public OperatorService(IOperatorRepository operatorRepository, IAddressRepository addressRepository)
		{
			_operatorRepository = operatorRepository;
			_addressRepository = addressRepository;
		}

		public IEnumerable<OperatorDto> GetAllOperators()
		{
			var operators = _operatorRepository.GetAll();

			var operatorDtoList = new List<OperatorDto>();

			operators.ToList().ForEach(t =>
				operatorDtoList.Add(Mapper.Map<Operator, OperatorDto>(t)));

			return operatorDtoList.OrderBy(t => t.Id);
		}

		public OperatorDto GetOperatorById(int id)
		{
			var operatorDB = _operatorRepository.FindById(id);

			if (operatorDB == null)
				throw new Exception("Operator was not found");

			return Mapper.Map<Operator, OperatorDto>(operatorDB);
		}

		public OperatorDto Create(OperatorDto dto)
		{
			var operatorDB = Mapper.Map<OperatorDto, Operator>(dto);

			_operatorRepository.Create(operatorDB);

			return Mapper.Map<Operator, OperatorDto>(_operatorRepository.FindById(operatorDB.Id));
		}

		public void Update(int id, UpdateOperatorDto dto)
		{
			var operatorDb = _operatorRepository.FindById(id);

			if (operatorDb == null)
				throw new Exception("Operator was not found");

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

			_operatorRepository.Update(operatorDb);
		}

		public void Remove(int id)
		{
			var operatorDb = _operatorRepository.FindById(id);

			if (operatorDb == null)
				throw new Exception("Operator was not found");

			_operatorRepository.Remove(operatorDb);
		}
	}
}
