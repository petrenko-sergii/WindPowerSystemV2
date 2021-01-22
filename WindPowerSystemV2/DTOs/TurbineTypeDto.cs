using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.EntityBaseDtos;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class TurbineTypeDto : TurbineTypeBaseDto
	{
		[JsonProperty(Order = 1)]
		public int Id { get; set; }

		[JsonProperty(Order = 7)]
		public ManufacturerDto Manufacturer { get; set; }
	}
}
