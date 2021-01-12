using Newtonsoft.Json;

namespace WindPowerSystemV2.DTOs.UpdateDtos
{
	[JsonObject(MemberSerialization.OptOut)]
	public class UpdateShareHolderDto
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }

		public int ShareHolderTypeId { get; set; }
	}
}
