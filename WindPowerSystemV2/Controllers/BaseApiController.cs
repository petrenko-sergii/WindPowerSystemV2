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