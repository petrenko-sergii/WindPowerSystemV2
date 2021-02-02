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
	public class ShareService : BaseService, IShareService
	{
		private readonly IShareRepository _shareRepository;
		private readonly ITurbineRepository _turbineRepository;
		private readonly IFarmRepository _farmRepository;
		private readonly IShareHolderRepository _shareHolderRepository;

		private readonly string _exceptionMsgShareShouldBelongToTurbineOrFarm = "Share should belong to turbine or farm (but not for both).";
		private readonly string _exceptionMsgSharePriceCanNotBeZeroOrNegative = "Share price can not be zero or negative.";

		public ShareService(IShareRepository shareRepository, ITurbineRepository turbineRepository, IFarmRepository farmRepository, IShareHolderRepository shareHolderRepository)
		{
			_shareRepository = shareRepository;
			_turbineRepository = turbineRepository;
			_farmRepository = farmRepository;
			_shareHolderRepository = shareHolderRepository;
		}

		public IEnumerable<ShareDto> GetAllShares()
		{
			var shares = _shareRepository.GetAll();

			var shareDtoList = new List<ShareDto>();

			shares.ToList().ForEach(t =>
				shareDtoList.Add(Mapper.Map<Share, ShareDto>(t)));

			return shareDtoList.OrderBy(t => t.Id);
		}

		public ShareDto GetShareById(int id)
		{
			var share = _shareRepository.FindById(id);

			if (share == null)
				throw new Exception("Share was not found");

			return Mapper.Map<Share, ShareDto>(share);
		}

		public void ValidatePostModel(ShareDto dto)
		{
			if(dto.Turbine != null && dto.Farm != null)
				throw new Exception(_exceptionMsgShareShouldBelongToTurbineOrFarm);

			ValidatePrice(dto.Price);

			if(dto.PurchaseDate == DateTime.MinValue)
				dto.PurchaseDate = DateTime.Now;
		}

		public void ValidateUpdateModel(UpdateShareDto dto)
		{
			if (dto.TurbineId != 0 && dto.FarmId != 0)
				throw new Exception(_exceptionMsgShareShouldBelongToTurbineOrFarm);

			ValidatePrice(dto.Price);
		}

		public ShareDto Create(ShareDto dto)
		{
			var share = Mapper.Map<ShareDto, Share>(dto);

			_shareRepository.Create(share);

			return Mapper.Map<Share, ShareDto>(_shareRepository.FindById(share.Id));
		}

		public void Update(int id, UpdateShareDto dto)
		{
			var share = _shareRepository.FindById(id);

			if (share == null)
				throw new Exception("Share was not found");

			if (dto.SerialNum != null)
				share.SerialNum = dto.SerialNum;

			if (dto.Percent != 0)
				share.Percent = dto.Percent;

			if (dto.Price != 0)
				share.Price = dto.Price;

			if(dto.TurbineId != 0 && share.Turbine != null && dto.TurbineId != share.Turbine.Id)
			{
				var turbine = _turbineRepository.FindById(dto.TurbineId);

				if (turbine != null)
					share.Turbine = turbine;
			}

			if (dto.FarmId != 0 && share.Farm != null && dto.FarmId != share.Farm.Id)
			{
				var farm = _farmRepository.FindById(dto.TurbineId);

				if (farm != null)
					share.Farm = farm;
			}

			if (dto.ShareHolderId != share.ShareHolder.Id)
			{
				var shareHolder = _shareHolderRepository.FindById(dto.ShareHolderId);

				if (shareHolder != null)
					share.ShareHolder = shareHolder;
			}

			_shareRepository.Update(share);
		}

		public void Remove(int id)
		{
			var share = _shareRepository.FindById(id);

			if (share == null)
				throw new Exception("Share was not found");

			_shareRepository.Remove(share);
		}

		private void ValidatePrice(decimal price)
		{
			if (price <= 0)
				throw new Exception(_exceptionMsgSharePriceCanNotBeZeroOrNegative);
		}
	}
}
