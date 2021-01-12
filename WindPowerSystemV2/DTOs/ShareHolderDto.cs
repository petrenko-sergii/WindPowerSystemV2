using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class ShareHolderDto
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }

		public ShareHolderTypeDto ShareHolderType { get; set; }
	}
}
