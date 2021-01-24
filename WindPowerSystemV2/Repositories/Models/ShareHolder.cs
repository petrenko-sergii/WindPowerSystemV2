using System.ComponentModel.DataAnnotations.Schema;
using WindPowerSystemV2.Repositories.Models.AddressModels;
using WindPowerSystemV2.Repositories.Models.BaseModels;

namespace WindPowerSystemV2.Repositories.Models
{
	public class ShareHolder : FirstLastNamesModel
	{
		public virtual int Id { get; set; }
		public virtual int AddressId { get; set; }
		public virtual int ShareHolderTypeId { get; set; }

		[ForeignKey("AddressId")]
		public virtual Address Address { get; set; }

		[ForeignKey("ShareHolderTypeId")]
		public virtual ShareHolderType ShareHolderType { get; set; }
	}
}
