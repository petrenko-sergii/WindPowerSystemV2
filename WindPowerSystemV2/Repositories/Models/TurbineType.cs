using System.ComponentModel.DataAnnotations;

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
