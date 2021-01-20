using Newtonsoft.Json;
using System;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class MetreItemDto
	{
		public int Id { get; set; }

		public DateTime MeasureDate { get; set; }
		public float Value { get; set; }
		public float CurProdCapacity { get; set; }
		public float HourQty { get; set; }
		public float AverageWind { get; set; }
		public float AverageDensity { get; set; }

		public TurbineDto Turbine { get; set; }
	}
}
