using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WindPowerSystemV2.Repositories.Models
{
	public class TurbineType
	{
		public TurbineType() { }

		[Key]
		[Required]
		public int Id { get; set; }

		[Required]
		public string Model { get; set; }

		[Required]
		public float Capacity { get; set; }
	}
}
