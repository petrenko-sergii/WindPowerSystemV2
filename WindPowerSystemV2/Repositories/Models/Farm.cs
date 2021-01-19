using System.ComponentModel.DataAnnotations.Schema;
using WindPowerSystemV2.Repositories.Models.AddressModels;
using WindPowerSystemV2.Repositories.Models.BaseModels;
using WindPowerSystemV2.Repositories.Models.ImageModels;

namespace WindPowerSystemV2.Repositories.Models
{
	public class Farm : ModelWithName
	{
		public virtual int AddressId { get; set; }
		public virtual int ImageId { get; set; }

		[ForeignKey("AddressId")]
		public virtual Address Address { get; set; }

		[ForeignKey("ImageId")]
		public virtual AppImage Image { get; set; }
	}
}
