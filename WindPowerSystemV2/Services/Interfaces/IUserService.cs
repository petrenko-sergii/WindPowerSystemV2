using System.Collections.Generic;
using WindPowerSystemV2.DTOs;

namespace WindPowerSystemV2.Services.Interfaces
{
	public interface IUserService
	{
		IEnumerable<UserDto> GetAllUsers();
		UserDto GetUserById(string id);
		UserDto Create(UserDto dto);
		void Update(int id, UserDto dto);
		void Remove(int id);
	}
}
