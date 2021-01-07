using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs.UpdateDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class UpdateTurbineDto
	{
		public string SerialNum { get; set; }
		public int ProdMW { get; set; }
	}
}
