using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Controllers
{
    [Route("api/User")]
    public class UserController
	{
		private readonly IUserService _userService;

		public UserController( IUserService userService)
		{
			_userService = userService;
		}

		// GET: api/User
		[HttpGet]
		public ActionResult<IEnumerable<UserDto>> Get()
		{
			var userDtos = _userService.GetAllUsers();

			return userDtos.ToList();
		}

		//GET: api/User/5
		[HttpGet("{id}")]
		public ActionResult<UserDto> Get(int id)
		{
			//return _userService.GetUserById(id);  //TODO: will be implemented
			return null;
		}

		//POST: api/User
		[HttpPost]
		public ActionResult<UserDto> Post([FromBody] UserDto dto)
		{
			return _userService.Create(dto);
		}

		// PUT: api/User/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] UserDto dto)
		{
			_userService.Update(id, dto);
		}

		// DELETE: api/User/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_userService.Remove(id);
		}
	}
}