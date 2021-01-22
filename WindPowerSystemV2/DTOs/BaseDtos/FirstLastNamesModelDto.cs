using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs.BaseDtos
{
	public abstract class FirstLastNamesModelDto
	{
		[JsonProperty(Order = 1)]
		public string FirstName { get; set; }

		[JsonProperty(Order = 2)]
		public string LastName { get; set; }

		[JsonProperty(Order = 3)]
		public string Email { get; set; }

		[JsonProperty(Order = 4)]
		public string Phone { get; set; }
	}
}
