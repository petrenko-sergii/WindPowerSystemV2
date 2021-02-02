using System.ComponentModel.DataAnnotations.Schema;
using WindPowerSystemV2.Repositories.Models.BaseModels;
using WindPowerSystemV2.Repositories.Models.ImageModels;

namespace WindPowerSystemV2.Repositories.Models.AddressModels
{
	public class Country : ModelWithName
	{
		public virtual int? FlagImageId { get; set; }

		[ForeignKey("FlagImageId")]
		public virtual FlagImage FlagImage { get; set; } 
	}
}
