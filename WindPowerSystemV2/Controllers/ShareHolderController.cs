using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WindPowerSystemV2.DTOs;
using WindPowerSystemV2.DTOs.UpdateDtos;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Controllers
{
    [Route("api/ShareHolder")]
    public class ShareHolderController
	{
		private readonly IShareHolderService _shareHolderService;

		public ShareHolderController( IShareHolderService shareHolderService)
		{
			_shareHolderService = shareHolderService;
		}

		// GET: api/ShareHolder
		[HttpGet]
		public ActionResult<IEnumerable<ShareHolderDto>> Get()
		{
			var shareHolderDtos = _shareHolderService.GetAllShareHolders();

			return shareHolderDtos.ToList();
		}

		//GET: api/ShareHolder/5
		[HttpGet("{id}")]
		public ActionResult<ShareHolderDto> Get(int id)
		{
			return _shareHolderService.GetShareHolderById(id);
		}

		//POST: api/ShareHolder
		[HttpPost]
		public ActionResult<ShareHolderDto> Post([FromBody] ShareHolderDto dto)
		{
			return _shareHolderService.Create(dto);
		}

		// PUT: api/ShareHolder/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] UpdateShareHolderDto dto)
		{
			_shareHolderService.Update(id, dto);
		}

		// DELETE: api/ShareHolder/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
			_shareHolderService.Remove(id);
		}
	}
}