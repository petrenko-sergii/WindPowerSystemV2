using Newtonsoft.Json;
using System;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class UserDto 
	{
		public string Id { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public DateTime RegisterDate { get; set; }
		public DateTime LastLoginDate { get; set; }
		public string Firstname { get; set; }
		public string LastName { get; set; }
		public int WrongPassworDeffort { get; set; }
		public bool Blocked { get; set; }
		public bool PasswordMustBeChanged { get; set; }
		public int LifeTimeForPassword { get; set; }
	}
}
