using Newtonsoft.Json;
using System;

namespace WindPowerSystemV2.DTOs.EntityBaseDtos
{
	public class ShareBaseDto
	{
		[JsonProperty(Order = 2)]
		public string SerialNum { get; set; }

		[JsonProperty(Order = 3)]
		public decimal Percent { get; set; }

		[JsonProperty(Order = 4)]
		public decimal Price { get; set; }

		[JsonProperty(Order = 5)]
		public DateTime PurchaseDate { get; set; }
	}
}
