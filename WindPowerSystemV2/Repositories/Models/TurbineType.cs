using System.ComponentModel.DataAnnotations.Schema;

namespace WindPowerSystemV2.Repositories.Models
{
	public class TurbineType
	{
		public virtual int Id { get; set; }
		public virtual string Model { get; set; }
		public virtual float Capacity { get; set; }
		public virtual float TowerHeight { get; set; }
		public virtual float RotorDiameter { get; set; }
		public virtual float SweptArea { get; set; }
		public virtual int ManufacturerId { get; set; }

		[ForeignKey("ManufacturerId")]
		public virtual Manufacturer Manufacturer { get; set; }
	}
}
