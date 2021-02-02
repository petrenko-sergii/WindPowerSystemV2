using Newtonsoft.Json;
using System;

namespace WindPowerSystemV2.DTOs.EntityBaseDtos
{
	public class TurbineBaseDto
	{
		[JsonProperty(Order = 2)]
		public string SerialNum { get; set; }

		[JsonProperty(Order = 3)]
		public DateTime InstallDate { get; set; }

		[JsonProperty(Order = 4)]
		public int ProdMW { get; set; }

		[JsonProperty(Order = 5)]
		public decimal Cost { get; set; }

		[JsonProperty(Order = 6)]
		public decimal InstallCost { get; set; }


		[JsonProperty(Order = 7)]
		public DateTime LastServDate { get; set; }

		[JsonProperty(Order = 8)]
		public DateTime NextServDate { get; set; }

		[JsonProperty(Order = 9)]
		public DateTime LastYearServDate { get; set; }

		[JsonProperty(Order = 10)]
		public DateTime NextYearServDate { get; set; }
	}
}
