using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WindPowerSystemV2.Controllers
{
	[Route("api/[controller]")]
	public class BaseApiController : Controller
	{
		protected JsonSerializerSettings JsonSettings { get; private set; }

		public BaseApiController()
		{
			// Instantiate a single JsonSerializerSettings object
			// that can be reused multiple times.
			JsonSettings = new JsonSerializerSettings()
			{
				Formatting = Formatting.Indented
			};
		}
	}
}