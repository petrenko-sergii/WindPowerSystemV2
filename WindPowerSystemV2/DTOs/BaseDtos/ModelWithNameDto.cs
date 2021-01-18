using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs.BaseDtos
{
	public abstract class ModelWithNameDto
	{
		[JsonProperty(Order = 1)]
		public int Id { get; set; }

		[JsonProperty(Order = 2)]
		public string Name { get; set; }
	}
}
