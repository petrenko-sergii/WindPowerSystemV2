using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Controllers
{
    [Route("api/Turbine")]
    public class TurbineController
	{
		private readonly ISessionFactory _sessionFactory;
		private readonly ITurbineService _turbineService;

		public TurbineController(ISessionFactory sessionFactory, ITurbineService turbineService)
		{
			_sessionFactory = sessionFactory;
			_turbineService = turbineService;
		}

		// GET: api/Turbine
		[HttpGet]
		public ActionResult<IEnumerable<TurbineDto>> Get()
		{
			using (var session = _sessionFactory.OpenSession())
			{
				var turbineDtos = _turbineService.GetAllTurbines(session);

				return turbineDtos.ToList();
			}
		}

		//GET: api/Turbine/5
		[HttpGet("{id}")]
		public ActionResult<TurbineDto> Get(int id)
		{
			using (var session = _sessionFactory.OpenSession())
			{
				return _turbineService.GetTurbineById(id, session);
			}
		}

		//POST: api/Turbine
		[HttpPost]
		public ActionResult<TurbineDto> Post([FromBody] TurbineDto dto) //TODO: create and use UpdateTurbineDto without Id-property
		{
			using (var session = _sessionFactory.OpenSession())
			{
				return _turbineService.Create(dto, session);
			}
		}

		// PUT: api/Turbine/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] TurbineDto dto)
		{
			using (var session = _sessionFactory.OpenSession())
			{
				_turbineService.Update(id, dto, session);
			}
		}

		// DELETE: api/Turbine/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			using (var session = _sessionFactory.OpenSession())
			{
				_turbineService.Remove(id, session);
			}
		}
	}
}