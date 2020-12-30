using NHibernate;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;

namespace WindPowerSystemV2.Repositories
{
	public class TurbineRepository : BaseRepository<Turbine>, ITurbineRepository
	{
		public TurbineRepository(ISessionFactory sessionFactory) : base(sessionFactory)
		{
		}
	}
}
