using Newtonsoft.Json;
using WindPowerSystemV2.DTOs.AddressDtos;
using WindPowerSystemV2.DTOs.EntityBaseDtos;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class TurbineDto : TurbineBaseDto
	{
		public int Id { get; set; }

		public TurbineTypeDto TurbineType { get; set; }
		public AddressDto Address { get; set; }
	}
}
