using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs.AddressDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class IndexDto
	{
		public int Id { get; set; }
		public string Value { get; set; }
	}
}
