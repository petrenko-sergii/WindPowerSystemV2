using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.BaseDtos;

namespace WindPowerSystemV2.DTOs.UpdateDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class UpdateShareHolderDto : FirstLastNamesModelDto
	{
		public int AddressId { get; set; }
		public int ShareHolderTypeId { get; set; }
	}
}
