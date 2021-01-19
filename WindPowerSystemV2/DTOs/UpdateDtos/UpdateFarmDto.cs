using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs.UpdateDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class UpdateFarmDto
	{
		public string Name { get; set; }
		public int AddressId { get; set; }
		public int ImageId { get; set; }
	}
}
