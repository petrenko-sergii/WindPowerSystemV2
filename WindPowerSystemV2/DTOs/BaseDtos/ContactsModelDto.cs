using WindPowerSystemV2.DTOs.AddressDtos;
using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs.BaseDtos
{
	public abstract class ContactsModelDto : ModelWithNameDto
	{
		[JsonProperty(Order = 3)]
		public string Email { get; set; }

		[JsonProperty(Order = 4)]
		public string Phone { get; set; }

		[JsonProperty(Order = 5)]
		public string Website { get; set; }

		[JsonProperty(Order = 6)]
		public AddressDto Address { get; set; }
	}
}
