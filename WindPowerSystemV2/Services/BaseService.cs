using AutoMapper;
using WindPowerSystemV2.Services.Interfaces;

namespace WindPowerSystemV2.Services
{
	public class BaseService : IBaseService
	{
		public IMapper Mapper { get; set; }
	}
}
