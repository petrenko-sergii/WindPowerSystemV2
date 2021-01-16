using System.ComponentModel.DataAnnotations.Schema;

namespace WindPowerSystemV2.Repositories.Models
{
	public class ShareHolder
	{
		public virtual int Id { get; set; }
		public virtual string FirstName { get; set; }
		public virtual string LastName { get; set; }
		public virtual string Email { get; set; }
		public virtual string Phone { get; set; }

		public virtual int ShareHolderTypeId { get; set; }

		[ForeignKey("ShareHolderTypeId")]
		public virtual ShareHolderType ShareHolderType { get; set; }
	}
}
