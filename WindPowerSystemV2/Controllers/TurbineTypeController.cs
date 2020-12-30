using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Controllers
{
    [Route("api/TurbineType")]
    public class TurbineTypeController
	{
		private readonly ISessionFactory _sessionFactory;
		private readonly ITurbineTypeService _turbineTypeService;

		public TurbineTypeController(ISessionFactory sessionFactory, ITurbineTypeService turbineTypeService)
		{
			_sessionFactory = sessionFactory;
			_turbineTypeService = turbineTypeService;
		}

		// GET: api/TurbineType
		[HttpGet]
		public ActionResult<IEnumerable<TurbineTypeDto>> Get()
		{
			using (var session = _sessionFactory.OpenSession())
			{
				var turbineTypeDtos = _turbineTypeService.GetAllTurbineTypes(session);

				return turbineTypeDtos.ToList();
			}
		}

		// GET: api/TurbineType/5
		[HttpGet("{id}", Name = "Get")]
		public ActionResult<TurbineTypeDto> Get(int id)
		{
			using (var session = _sessionFactory.OpenSession())
			{
				return _turbineTypeService.GetTurbineTypeById(id, session);
			}
		}

		//POST: api/TurbineType
		[HttpPost]
		//[ProducesResponseType(typeof(TurbineTypeDto), StatusCodes.Status201Created)]
		public ActionResult<TurbineTypeDto> Post([FromBody] TurbineTypeDto dto) //TODO: create and use UpdateTurbineTypeDto without Id-property
		{
			using (var session = _sessionFactory.OpenSession())
			{
				return _turbineTypeService.Create(dto, session);
			}
		}

		// PUT: api/TurbineType/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] TurbineTypeDto dto)
		{
			using (var session = _sessionFactory.OpenSession())
			{
				_turbineTypeService.Update(id, dto, session);
			}
		}

		// DELETE: api/TurbineType/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			using (var session = _sessionFactory.OpenSession())
			{
				_turbineTypeService.Remove(id, session);
			}
		}
	}
}