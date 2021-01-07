using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs.UpdateDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class UpdateShareDto
	{
		public string SerialNum { get; set; }
		public decimal Percent { get; set; }
		public decimal Price { get; set; }
	}
}
