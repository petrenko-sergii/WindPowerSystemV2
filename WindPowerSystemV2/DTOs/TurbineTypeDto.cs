using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.EntityBaseDtos;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class TurbineTypeDto : TurbineTypeBaseDto
	{
		public int Id { get; set; }
	}
}
