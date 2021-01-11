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

		public ShareService(IShareRepository shareRepository, ITurbineRepository turbineRepository)
		{
			_shareRepository = shareRepository;
			_turbineRepository = turbineRepository;
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

			if(dto.TurbineId != share.Turbine.Id)
			{
				var turbine = _turbineRepository.FindById(dto.TurbineId);

				if (turbine != null)
					share.Turbine = turbine;
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
	}
}
