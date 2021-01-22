using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs.EntityBaseDtos
{
	public class TurbineTypeBaseDto
	{
		[JsonProperty(Order = 2)]
		public string Model { get; set; }

		[JsonProperty(Order = 3)]
		public float Capacity { get; set; }

		[JsonProperty(Order = 4)]
		public float TowerHeight { get; set; }

		[JsonProperty(Order = 5)]
		public float RotorDiameter { get; set; }

		[JsonProperty(Order = 6)]
		public float SweptArea { get; set; }

	}
}
