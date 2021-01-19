using NHibernate;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;

namespace WindPowerSystemV2.Repositories
{
	public class FarmRepository : BaseRepository<Farm>, IFarmRepository
	{
		public FarmRepository(ISession session) : base(session)
		{
		}
	}
}
