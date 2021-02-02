using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Controllers
{
    [Route("api/Turbine")]
    public class TurbineController
	{
		private readonly ITurbineService _turbineService;

		public TurbineController( ITurbineService turbineService)
		{
			_turbineService = turbineService;
		}

		// GET: api/Turbine
		[HttpGet]
		public ActionResult<IEnumerable<TurbineDto>> Get()
		{
			var turbineDtos = _turbineService.GetAllTurbines();

			return turbineDtos.ToList();
		}

		//GET: api/Turbine/5
		[HttpGet("{id}")]
		public ActionResult<TurbineDto> Get(int id)
		{
			return _turbineService.GetTurbineById(id);
		}

		//POST: api/Turbine
		[HttpPost]
		public ActionResult<TurbineDto> Post([FromBody] TurbineDto dto)
		{
			_turbineService.ValidatePostModel(dto);
			return _turbineService.Create(dto);
		}

		// PUT: api/Turbine/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] UpdateTurbineDto dto)
		{
			_turbineService.Update(id, dto);
		}

		// DELETE: api/Turbine/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_turbineService.Remove(id);
		}
	}
}