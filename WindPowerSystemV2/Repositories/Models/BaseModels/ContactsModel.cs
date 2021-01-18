using System.ComponentModel.DataAnnotations.Schema;
using WindPowerSystemV2.Repositories.Models.AddressModels;

namespace WindPowerSystemV2.Repositories.Models.BaseModels
{
	public abstract class ContactsModel : ModelWithName
	{
		public virtual string Email { get; set; }
		public virtual string Phone { get; set; }
		public virtual string Website { get; set; }
		public virtual int AddressId { get; set; }

		[ForeignKey("AddressId")]
		public virtual Address Address { get; set; }
	}
}
