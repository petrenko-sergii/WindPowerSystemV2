using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.EntityBaseDtos;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class ShareHolderDto : ShareHolderBaseDto
	{
		public int Id { get; set; }

		public ShareHolderTypeDto ShareHolderType { get; set; }
	}
}
