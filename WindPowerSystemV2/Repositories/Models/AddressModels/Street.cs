using System.ComponentModel.DataAnnotations.Schema;
using WindPowerSystemV2.Repositories.Models.BaseModels;

namespace WindPowerSystemV2.Repositories.Models.AddressModels
{
	public class Street : ModelWithName
	{
		public Street() {}

		public virtual int TownId { get; set; }
		public virtual int IndexId { get; set; }

		[ForeignKey("TownId")]
		public virtual Town Town { get; set; }

		[ForeignKey("IndexId")]
		public virtual Index Index { get; set; }
	}
}
