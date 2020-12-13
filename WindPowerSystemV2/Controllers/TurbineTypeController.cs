﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Controllers
{
    [Route("api/TurbineType")]
    public class TurbineTypeController : BaseApiController
	{
		private readonly ITurbineTypeService _turbineTypeService;

		public TurbineTypeController(ITurbineTypeService turbineTypeService)
		{
			_turbineTypeService = turbineTypeService;
		}

		// GET: api/TurbineType
		[HttpGet]
		public ActionResult<IEnumerable<TurbineTypeDto>> Get()
		{
			var turbineTypeDtos = _turbineTypeService.GetAllTurbineTypes();

			return turbineTypeDtos.ToList();
		}

		// GET: api/TurbineType/5
		//[HttpGet("{id}", Name = "Get")]
		//public IActionResult Get(int id)
		//{
		//	var turbineTypeDto = _turbineTypeService.GetTurbineTypeById(id);

		//	return new JsonResult(turbineTypeDto, JsonSettings);
		//}

		// use for .NET Core 2.1 (and above) -- use ActionResult<TurbineTypeDto>
		//public ActionResult<TurbineTypeDto> Get(int id)
		//{
		//	return _turbineTypeService.GetTurbineTypeById(id);
		//}

		//POST: api/TurbineType
		[HttpPost]
		//[ProducesResponseType(typeof(TurbineTypeDto), StatusCodes.Status201Created)]
		public ActionResult<TurbineTypeDto> Post([FromBody] TurbineTypeDto dto)
		{
			return _turbineTypeService.Create(dto);
		}

		// PUT: api/TurbineType/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] TurbineTypeDto dto)
		{
			//_turbineTypeService.UpdateTurbineType(id, dto);
		}

		// DELETE: api/ApiWithActions/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			// TO DO
		}
	}
}