using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.BaseDtos;

namespace WindPowerSystemV2.DTOs.AddressDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class StreetDto : ModelWithNameDto
	{
		public TownDto Town { get; set; }
		public IndexDto Index { get; set; }
	}
}
