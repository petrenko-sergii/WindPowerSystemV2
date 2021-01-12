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
	public class ShareHolderService : BaseService, IShareHolderService
	{
		private readonly IShareHolderRepository _shareHolderRepository;
		private readonly IShareHolderTypeRepository _shareHolderTypeRepository;

		public ShareHolderService(IShareHolderRepository shareHolderRepository, IShareHolderTypeRepository shareHolderTypeRepository)
		{
			_shareHolderRepository = shareHolderRepository;
			_shareHolderTypeRepository = shareHolderTypeRepository;
		}

		public IEnumerable<ShareHolderDto> GetAllShareHolders()
		{
			var shareHolders = _shareHolderRepository.GetAll();

			var shareHolderDtoList = new List<ShareHolderDto>();

			shareHolders.ToList().ForEach(t =>
				shareHolderDtoList.Add(Mapper.Map<ShareHolder, ShareHolderDto>(t)));

			return shareHolderDtoList.OrderBy(t => t.Id);
		}

		public ShareHolderDto GetShareHolderById(int id)
		{
			var shareHolder = _shareHolderRepository.FindById(id);

			if (shareHolder == null)
				throw new Exception("ShareHolder was not found");

			return Mapper.Map<ShareHolder, ShareHolderDto>(shareHolder);
		}

		public ShareHolderDto Create(ShareHolderDto dto)
		{
			var shareHolder = Mapper.Map<ShareHolderDto, ShareHolder>(dto);

			_shareHolderRepository.Create(shareHolder);

			return Mapper.Map<ShareHolder, ShareHolderDto>(_shareHolderRepository.FindById(shareHolder.Id));
		}

		public void Update(int id, UpdateShareHolderDto dto)
		{
			var shareHolder = _shareHolderRepository.FindById(id);

			if (shareHolder == null)
				throw new Exception("ShareHolder was not found");

			if (dto.FirstName != null)
				shareHolder.FirstName = dto.FirstName;

			if (dto.LastName != null)
				shareHolder.LastName = dto.LastName;

			if (dto.Email != null)
				shareHolder.Email = dto.Email;

			if (dto.Phone != null)
				shareHolder.Phone = dto.Phone;

			if (dto.ShareHolderTypeId != shareHolder.ShareHolderType.Id)
			{
				var shareHolderType = _shareHolderTypeRepository.FindById(dto.ShareHolderTypeId);

				if(shareHolderType != null)
					shareHolder.ShareHolderType = shareHolderType;
			}

			_shareHolderRepository.Update(shareHolder);
		}

		public void Remove(int id)
		{
			var shareHolder = _shareHolderRepository.FindById(id);

			if (shareHolder == null)
				throw new Exception("ShareHolder was not found");

			_shareHolderRepository.Remove(shareHolder);
		}
	}
}
