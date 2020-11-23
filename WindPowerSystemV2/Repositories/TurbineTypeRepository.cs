using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;

namespace WindPowerSystemV2.Repositories
{
	public class TurbineTypeRepository : BaseRepository<TurbineType>, ITurbineTypeRepository
	{
		public TurbineTypeRepository(Context dbContext) : base(dbContext)
		{
		}
	}
}
