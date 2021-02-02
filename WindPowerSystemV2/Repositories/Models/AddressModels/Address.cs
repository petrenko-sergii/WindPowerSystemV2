using System.ComponentModel.DataAnnotations.Schema;

namespace WindPowerSystemV2.Repositories.Models.AddressModels
{
	public class Address
	{
		public virtual int Id { get; set; }

		public virtual int CountryId { get; set; }
		public virtual int IndexId { get; set; }
		public virtual int TownId { get; set; }
		public virtual int StreetId { get; set; }
		public virtual int BuildingId { get; set; }
		public virtual int? FlatPartId { get; set; }

		[ForeignKey("CountryId")]
		public virtual Country Country { get; set; }

		[ForeignKey("IndexId")]
		public virtual Index Index { get; set; }

		[ForeignKey("TownId")]
		public virtual Town Town { get; set; }

		[ForeignKey("StreetId")]
		public virtual Street Street { get; set; }

		[ForeignKey("BuildingId")]
		public virtual BuildingNumber BuildingNumber { get; set; }

		[ForeignKey("FlatPartId")]
		public virtual FlatPart FlatPart { get; set; }
	}
}
