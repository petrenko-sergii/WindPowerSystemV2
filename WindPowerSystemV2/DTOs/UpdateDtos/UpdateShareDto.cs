using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.EntityBaseDtos;

namespace WindPowerSystemV2.DTOs.UpdateDtos
{
	[JsonObject(MemberSerialization.OptOut)]

	public class UpdateShareDto : ShareBaseDto
	{
		public int TurbineId { get; set; }
	}
}
