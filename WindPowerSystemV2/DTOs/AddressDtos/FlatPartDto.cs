using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.BaseDtos;

namespace WindPowerSystemV2.DTOs.AddressDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class FlatPartDto : ModelWithNameDto
	{
		public int Value { get; set; }

		public BuildingNumberDto BuildingNumber { get; set; }
	}
}
