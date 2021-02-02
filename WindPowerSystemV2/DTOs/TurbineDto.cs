using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.AddressDtos;
using WindPowerSystemV2.DTOs.EntityBaseDtos;
using WindPowerSystemV2.DTOs.ImageDtos;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class TurbineDto : TurbineBaseDto
	{
		[JsonProperty(Order = 1)]
		public int Id { get; set; }

		[JsonProperty(Order = 11)]
		public TurbineTypeDto TurbineType { get; set; }

		[JsonProperty(Order = 12)]
		public OperatorDto Operator { get; set; }

		[JsonProperty(Order = 13)]
		public FarmDto Farm { get; set; }

		[JsonProperty(Order = 14)]
		public AddressDto Address { get; set; }

		[JsonProperty(Order = 15)]
		public AppImageDto Image { get; set; }
	}
}
