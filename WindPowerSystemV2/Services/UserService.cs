using System;
using System.Collections.Generic;
using System.Linq;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Services
{
	public class UserService : BaseService, IUserService
	{
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		public IEnumerable<UserDto> GetAllUsers()
		{
			var users = _userRepository.GetAll();

			var userDtoList = new List<UserDto>();

			users.ToList().ForEach(t =>
				userDtoList.Add(Mapper.Map<User, UserDto>(t)));

			return userDtoList.OrderBy(t => t.Id);
		}

		//public UserDto GetUserById(int id)
		//{
		//	var user = _userRepository.FindById(id);

		//	if (user == null)
		//		throw new Exception("User was not found");

		//	return Mapper.Map<User, UserDto>(user);
		//}

		public UserDto Create(UserDto dto)
		{
			return new UserDto(); //TODO: will be implemented
		}

		public void Update(int id, UserDto dto)
		{
			//TODO: will be implemented
		}

		public void Remove(int id)
		{
			//TODO: will be implemented
		}
	}
}
