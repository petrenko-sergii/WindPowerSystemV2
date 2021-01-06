using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class ShareDto
	{
		public int Id { get; set; }
		public string SerialNum { get; set; }
		public decimal Percent { get; set; }
		public decimal Price { get; set; }

		public TurbineDto Turbine { get; set; }
	}
}
