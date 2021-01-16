using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.AddressDtos;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class TurbineDto
	{
		public int Id { get; set; }
		public string SerialNum { get; set; }
		public int ProdMW { get; set; }

		public TurbineTypeDto TurbineType { get; set; }
		public AddressDto Address { get; set; }
	}
}
