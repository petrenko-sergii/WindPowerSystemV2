using System.Collections.Generic;
using WindPowerSystemV2.DTOs;

namespace WindPowerSystemV2.Services.Interfaces
{
	public interface IShareService
	{
		IEnumerable<ShareDto> GetAllShares();
		ShareDto GetShareById(int id);
		ShareDto Create(ShareDto dto);
		void Update(int id, ShareDto dto);
		void Remove(int id);
	}
}
