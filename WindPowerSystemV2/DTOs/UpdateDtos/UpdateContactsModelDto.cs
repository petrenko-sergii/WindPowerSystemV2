namespace WindPowerSystemV2.DTOs.UpdateDtos
{
	public class UpdateContactsModelDto
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string Website { get; set; }

		public int AddressId { get; set; }
	}
}
