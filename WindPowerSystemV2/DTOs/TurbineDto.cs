using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class TurbineDto
	{
		public int Id { get; set; }
		public string SerialNum { get; set; }
		public int ProdMW { get; set; }
	}
}
