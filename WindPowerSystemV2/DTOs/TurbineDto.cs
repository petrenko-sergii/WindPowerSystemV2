using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class TurbineDto
	{
		public int Id { get; set; }
		public string SerialNum { get; set; }
		public int ProdMW { get; set; }

		public TurbineTypeDto TurbineType { get; set; }
	}
}
