using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindPowerSystemV2.Repositories.Models
{
	public class MeterItem
	{
		public virtual int Id { get; set; }
		public virtual DateTime MeasureDate { get; set; }
		public virtual float Value { get; set; }
		public virtual float CurProdCapacity { get; set; }
		public virtual float HourQty { get; set; }
		public virtual float AverageWind { get; set; }
		public virtual float AverageDensity { get; set; }

		public virtual int TurbineId { get; set; }

		[ForeignKey("TurbineId")]
		public virtual Turbine Turbine { get; set; }
	}
}
