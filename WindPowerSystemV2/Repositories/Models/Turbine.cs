using System.ComponentModel.DataAnnotations.Schema;
using WindPowerSystemV2.Repositories.Models.AddressModels;

namespace WindPowerSystemV2.Repositories.Models
{
	public class Turbine
	{
		public virtual int Id { get; set; }
		public virtual string SerialNum { get; set; }
		public virtual int ProdMW { get; set; }

		public virtual int TurbineTypeId { get; set; }
		public virtual int AddressId { get; set; }

		[ForeignKey("TurbineTypeId")]
		public virtual TurbineType TurbineType { get; set; }

		[ForeignKey("AddressId")]
		public virtual Address Address { get; set; }
	}
}
