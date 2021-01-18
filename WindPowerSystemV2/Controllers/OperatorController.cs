using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Controllers
{
    [Route("api/Operator")]
    public class OperatorController
	{
		private readonly IOperatorService _operatorService;

		public OperatorController( IOperatorService operatorService)
		{
			_operatorService = operatorService;
		}

		// GET: api/Operator
		[HttpGet]
		public ActionResult<IEnumerable<OperatorDto>> Get()
		{
			var operatorDtos = _operatorService.GetAllOperators();

			return operatorDtos.ToList();
		}

		//GET: api/Operator/5
		[HttpGet("{id}")]
		public ActionResult<OperatorDto> Get(int id)
		{
			return _operatorService.GetOperatorById(id);
		}

		//POST: api/Operator
		[HttpPost]
		public ActionResult<OperatorDto> Post([FromBody] OperatorDto dto)
		{
			return _operatorService.Create(dto);
		}

		// PUT: api/Operator/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] UpdateOperatorDto dto)
		{
			_operatorService.Update(id, dto);
		}

		// DELETE: api/Operator/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_operatorService.Remove(id);
		}
	}
}