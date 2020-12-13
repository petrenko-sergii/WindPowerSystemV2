using NHibernate;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;

namespace WindPowerSystemV2.Repositories
{
	public class TurbineTypeRepository : BaseRepository<TurbineType>, ITurbineTypeRepository
	{
		public TurbineTypeRepository(ISessionFactory sessionFactory) : base(sessionFactory)
		{
		}
	}
}
