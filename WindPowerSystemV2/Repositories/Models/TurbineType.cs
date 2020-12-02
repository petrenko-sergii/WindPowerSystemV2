using System.ComponentModel.DataAnnotations;

namespace WindPowerSystemV2.Repositories.Models
{
	public class TurbineType
	{
		public TurbineType() { }

		//[Key]
		//[Required]
		public virtual int Id { get; set; }

		//[Required]
		public virtual string Model { get; set; }

		//[Required]
		public virtual float Capacity { get; set; }
	}
}
