using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs.AddressDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class AddressDto
	{
		public int Id { get; set; }

		public int CountryId { get; set; }
		public string CountryName { get; set; }

		public int IndexId { get; set; }
		public string IndexValue { get; set; }

		public int TownId { get; set; }
		public string TownName { get; set; }

		public int StreetId { get; set; }
		public string StreetName { get; set; }

		public int BuildingNumberId { get; set; }
		public string BuildingNumberValue { get; set; }

		public int FlatPartId { get; set; }
		public string FlatPartName { get; set; }
	}
}
