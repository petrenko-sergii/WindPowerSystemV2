using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Controllers
{
    [Route("api/Farm")]
    public class FarmController
	{
		private readonly IFarmService _farmService;

		public FarmController( IFarmService farmService)
		{
			_farmService = farmService;
		}

		// GET: api/Farm
		[HttpGet]
		public ActionResult<IEnumerable<FarmDto>> Get()
		{
			var farmDtos = _farmService.GetAllFarms();

			return farmDtos.ToList();
		}

		//GET: api/Farm/5
		[HttpGet("{id}")]
		public ActionResult<FarmDto> Get(int id)
		{
			return _farmService.GetFarmById(id);
		}

		//POST: api/Farm
		[HttpPost]
		public ActionResult<FarmDto> Post([FromBody] FarmDto dto)
		{
			return _farmService.Create(dto);
		}

		// PUT: api/Farm/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] UpdateFarmDto dto)
		{
			_farmService.Update(id, dto);
		}

		// DELETE: api/Farm/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_farmService.Remove(id);
		}
	}
}