using System.ComponentModel.DataAnnotations.Schema;
using WindPowerSystemV2.Repositories.Models.BaseModels;

namespace WindPowerSystemV2.Repositories.Models.AddressModels
{
	public class FlatPart : ModelWithName
	{
		public FlatPart() {}

		public virtual int Value { get; set; }

		public virtual int BuildingNumberId { get; set; }

		[ForeignKey("BuildingNumberId")]
		public virtual BuildingNumber BuildingNumber { get; set; }
	}
}
