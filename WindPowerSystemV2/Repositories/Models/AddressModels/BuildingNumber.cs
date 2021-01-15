using System.ComponentModel.DataAnnotations.Schema;
using WindPowerSystemV2.Repositories.Models.BaseModels;
using WindPowerSystemV2.Repositories.Models.ImageModels;

namespace WindPowerSystemV2.Repositories.Models.AddressModels
{
	public class BuildingNumber : ModelWithValue
	{
		public BuildingNumber() {}

		public virtual float Latitude { get; set; }
		public virtual float Longitude { get; set; }

		public virtual int StreetId { get; set; }
		public virtual int ImageId { get; set; }

		[ForeignKey("StreetId")]
		public virtual Street Street { get; set; }

		[ForeignKey("ImageId")]
		public virtual AddressImage Image { get; set; }
	}
}
