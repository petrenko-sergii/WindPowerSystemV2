using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.AddressDtos;
using WindPowerSystemV2.DTOs.BaseDtos;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class ShareHolderDto : FirstLastNamesModelDto
	{
		[JsonProperty(Order = 1)]
		public int Id { get; set; }

		[JsonProperty(Order = 5)]
		public ShareHolderTypeDto ShareHolderType { get; set; }

		[JsonProperty(Order = 6)]
		public AddressDto Address { get; set; }
	}
}
