using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.EntityBaseDtos;

namespace WindPowerSystemV2.DTOs.UpdateDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class UpdateTurbineDto : TurbineBaseDto
	{
		public int TurbineTypeId { get; set; }
		public int AddressId { get; set; }
	}
}
