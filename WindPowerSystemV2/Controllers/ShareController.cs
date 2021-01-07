using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Controllers
{
    [Route("api/Share")]
    public class ShareController
	{
		private readonly IShareService _shareService;

		public ShareController( IShareService shareService)
		{
			_shareService = shareService;
		}

		// GET: api/Share
		[HttpGet]
		public ActionResult<IEnumerable<ShareDto>> Get()
		{
			var shareDtos = _shareService.GetAllShares();

			return shareDtos.ToList();
		}

		//GET: api/Share/5
		[HttpGet("{id}")]
		public ActionResult<ShareDto> Get(int id)
		{
			return _shareService.GetShareById(id);
		}

		//POST: api/Share
		[HttpPost]
		public ActionResult<ShareDto> Post([FromBody] ShareDto dto)
		{
			return _shareService.Create(dto);
		}

		// PUT: api/Share/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] UpdateShareDto dto)
		{
			_shareService.Update(id, dto);
		}

		// DELETE: api/Share/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_shareService.Remove(id);
		}
	}
}