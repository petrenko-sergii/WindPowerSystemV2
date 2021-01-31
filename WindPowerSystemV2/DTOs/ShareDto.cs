using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.EntityBaseDtos;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class ShareDto : ShareBaseDto
	{
		[JsonProperty(Order = 1)]
		public int Id { get; set; }

		[JsonProperty(Order = 6)]
		public TurbineDto Turbine { get; set; }

		[JsonProperty(Order = 7)]
		public FarmDto Farm { get; set; }

		[JsonProperty(Order = 8)]
		public ShareHolderDto ShareHolder { get; set; }
	}
}
