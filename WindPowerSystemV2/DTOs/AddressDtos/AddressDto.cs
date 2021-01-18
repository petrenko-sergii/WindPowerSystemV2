using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs.AddressDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class AddressDto
	{
		public int Id { get; set; }
		
		public string Country { get; set; }
		public string Index { get; set; }
		public string Town { get; set; }
		public string Street { get; set; }
		public string BuildingNumber { get; set; }
		public string FlatPart { get; set; }

		public int CountryId { get; set; }
		public int IndexId { get; set; }
		public int TownId { get; set; }
		public int StreetId { get; set; }
		public int BuildingNumberId { get; set; }
		public int? FlatPartId { get; set; }
	}
}
