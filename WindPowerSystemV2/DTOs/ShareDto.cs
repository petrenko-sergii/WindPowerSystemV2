using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.EntityBaseDtos;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class ShareDto : ShareBaseDto
	{
		public int Id { get; set; }

		public TurbineDto Turbine { get; set; }
	}
}
