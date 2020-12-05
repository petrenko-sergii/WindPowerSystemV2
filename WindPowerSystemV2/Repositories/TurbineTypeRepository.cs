using System.Linq;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;
using NHibernate;

namespace WindPowerSystemV2.Repositories
{
	public class TurbineTypeRepository : BaseRepository<TurbineType>, ITurbineTypeRepository
	{
		private ISessionFactory _sessionFactory;

		public TurbineTypeRepository(ISessionFactory sessionFactory) : base(sessionFactory)
		{
			_sessionFactory = sessionFactory;
		}

		public override IQueryable<TurbineType> GetAll()
		{
			using (var session = _sessionFactory.OpenSession())
			{
				using (var tx = session.BeginTransaction())
				{
					var turbineTypes = session.CreateCriteria<TurbineType>().List<TurbineType>();

					dbSet = turbineTypes.AsQueryable();

					tx.Commit();
				}
			}

			return dbSet.AsQueryable();
		}
	}
}
