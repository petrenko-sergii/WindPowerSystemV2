using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Controllers
{
    [Route("api/Manufacturer")]
    public class ManufacturerController : ControllerBase
	{
		private readonly IManufacturerService _manufacturerService;

		public ManufacturerController( IManufacturerService manufacturerService)
		{
			_manufacturerService = manufacturerService;
		}

		// GET: api/Manufacturer
		[HttpGet]
		public ActionResult<IEnumerable<ManufacturerDto>> Get()
		{
			var manufacturerDtos = _manufacturerService.GetAllManufacturers();

			return manufacturerDtos.ToList();
		}

		//GET: api/Manufacturer/5
		[HttpGet("{id}")]
		public ActionResult<ManufacturerDto> Get(int id)
		{
			return _manufacturerService.GetManufacturerById(id);
		}

		//POST: api/Manufacturer
		[HttpPost]
		public ActionResult<ManufacturerDto> Post([FromBody] ManufacturerDto dto)
		{
			return _manufacturerService.Create(dto);
		}

		// PUT: api/Manufacturer/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] UpdateManufacturerDto dto)
		{
			_manufacturerService.Update(id, dto);
		}

		// DELETE: api/Manufacturer/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_manufacturerService.Remove(id);
		}
	}
}