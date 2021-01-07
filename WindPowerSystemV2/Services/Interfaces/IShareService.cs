using System.Collections.Generic;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;

namespace WindPowerSystemV2.Services.Interfaces
{
	public interface IShareService
	{
		IEnumerable<ShareDto> GetAllShares();
		ShareDto GetShareById(int id);
		ShareDto Create(ShareDto dto);
		void Update(int id, UpdateShareDto dto);
		void Remove(int id);
	}
}
