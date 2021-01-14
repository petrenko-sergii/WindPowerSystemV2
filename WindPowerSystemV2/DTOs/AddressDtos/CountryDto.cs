using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.BaseDtos;
using WindPowerSystemV2.DTOs.ImageDtos;

namespace WindPowerSystemV2.DTOs.AddressDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class CountryDto : ModelWithNameDto
	{
		public FlagImageDto FlagImage { get; set; }
	}
}
