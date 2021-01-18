using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs.UpdateDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class UpdateManufacturerDto
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Website { get; set; }

		public int AddressId { get; set; }
	}
}
