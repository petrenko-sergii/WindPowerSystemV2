using System.ComponentModel.DataAnnotations.Schema;
using WindPowerSystemV2.Repositories.Models.BaseModels;

namespace WindPowerSystemV2.Repositories.Models.AddressModels
{
	public class Town : ModelWithName
	{
		public Town() {}

		public virtual int CountryId { get; set; }

		[ForeignKey("CountryId")]
		public virtual Country Country { get; set; } 
	}
}
