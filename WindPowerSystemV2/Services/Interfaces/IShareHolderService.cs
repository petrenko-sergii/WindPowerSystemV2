using System.Collections.Generic;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;

namespace WindPowerSystemV2.Services.Interfaces
{
	public interface IShareHolderService
	{
		IEnumerable<ShareHolderDto> GetAllShareHolders();
		ShareHolderDto GetShareHolderById(int id);
		ShareHolderDto Create(ShareHolderDto dto);
		void Update(int id, UpdateShareHolderDto dto);
		void Remove(int id);
	}
}
