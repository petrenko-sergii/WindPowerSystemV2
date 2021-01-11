using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class ShareHolderTypeDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
