using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.BaseDtos;

namespace WindPowerSystemV2.DTOs.AddressDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class BuildingNumberDto : ModelWithValueDto
	{
		public float Latitude { get; set; }
		public float Longitude { get; set; }

		public StreetDto Street { get; set; }
	}
}
