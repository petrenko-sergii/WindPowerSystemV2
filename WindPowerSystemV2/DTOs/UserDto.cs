using Newtonsoft.Json;
using System;
using WindPowerSystemV2.DTOs.BaseDtos;

namespace WindPowerSystemV2.DTOs
{
	[JsonObject(MemberSerialization.OptOut)]
	public class UserDto : FirstLastNamesModelDto
	{
		[JsonProperty(Order = 11)]
		public string Id { get; set; }

		[JsonProperty(Order = 5)]
		public DateTime RegisterDate { get; set; }

		[JsonProperty(Order = 6)]
		public DateTime LastLoginDate { get; set; }

		[JsonProperty(Order = 7)]
		public int WrongPassworDeffort { get; set; }

		[JsonProperty(Order = 8)]
		public bool Blocked { get; set; }

		[JsonProperty(Order = 9)]
		public bool PasswordMustBeChanged { get; set; }

		[JsonProperty(Order = 10)]
		public int LifeTimeForPassword { get; set; }
	}
}
