using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs.UpdateDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class UpdateTurbineTypeDto
	{
		public string Model { get; set; }
		public float Capacity { get; set; }
		public float TowerHeight { get; set; }
		public float RotorDiameter { get; set; }
		public float SweptArea { get; set; }
	}
}
