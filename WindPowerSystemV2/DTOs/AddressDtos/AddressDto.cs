using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs.AddressDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class AddressDto
	{
		public int Id { get; set; }

		public CountryDto Country { get; set; }
		public IndexDto Index { get; set; }
		public TownDto Town { get; set; }
		public StreetDto Street { get; set; }
		public BuildingNumberDto BuildingNumber { get; set; }
		public FlatPartDto FlatPart { get; set; }
	}
}
