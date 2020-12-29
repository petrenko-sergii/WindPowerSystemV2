﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class TurbineTypeDto
	{
		public int Id { get; set; }
		public string Model { get; set; }
		public float Capacity { get; set; }
		public float TowerHeight { get; set; }
		public float RotorDiameter { get; set; }
		public float SweptArea { get; set; }
	}
}
