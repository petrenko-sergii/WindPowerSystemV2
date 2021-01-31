using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindPowerSystemV2.Repositories.Models
{
	public class Share
	{
		public virtual int Id { get; set; }
		public virtual string SerialNum { get; set; }
		public virtual decimal Percent { get; set; }
		public virtual decimal Price { get; set; }
		public virtual DateTime PurchaseDate { get; set; }

		public virtual int TurbineId { get; set; }
		public virtual int FarmId { get; set; }
		public virtual int ShareHolderId { get; set; }

		[ForeignKey("TurbineId")]
		public virtual Turbine Turbine { get; set; }

		[ForeignKey("FarmId")]
		public virtual Farm Farm { get; set; }

		[ForeignKey("ShareHolderId")]
		public virtual ShareHolder ShareHolder { get; set; }
	}
}
