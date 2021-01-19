using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.AddressDtos;
using WindPowerSystemV2.DTOs.BaseDtos;
using WindPowerSystemV2.DTOs.ImageDtos;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class FarmDto : ModelWithNameDto
	{
		public AddressDto Address { get; set; }
		public AppImageDto Image { get; set; }
	}
}
