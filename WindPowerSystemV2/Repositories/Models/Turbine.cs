using System;
using System.ComponentModel.DataAnnotations.Schema;
using WindPowerSystemV2.Repositories.Models.AddressModels;
using WindPowerSystemV2.Repositories.Models.ImageModels;

namespace WindPowerSystemV2.Repositories.Models
{
	public class Turbine
	{
		public virtual int Id { get; set; }
		public virtual string SerialNum { get; set; }
		public virtual DateTime InstallDate { get; set; }
		public virtual int ProdMW { get; set; }
		public virtual decimal Cost { get; set; }
		public virtual decimal InstallCost { get; set; }

		public virtual int TurbineTypeId { get; set; }
		public virtual int OperatorId { get; set; }
		public virtual int? FarmId { get; set; }
		public virtual int AddressId { get; set; }
		public virtual int? ImageId { get; set; }
		public virtual DateTime LastServDate { get; set; }
		public virtual DateTime NextServDate { get; set; }
		public virtual DateTime LastYearServDate { get; set; }
		public virtual DateTime NextYearServDate { get; set; }

		[ForeignKey("TurbineTypeId")]
		public virtual TurbineType TurbineType { get; set; }

		[ForeignKey("OperatorId")]
		public virtual Operator Operator { get; set; }

		[ForeignKey("FarmId")]
		public virtual Farm Farm { get; set; }

		[ForeignKey("AddressId")]
		public virtual Address Address { get; set; }

		[ForeignKey("ImageId")]
		public virtual AppImage Image { get; set; }
	}
}
