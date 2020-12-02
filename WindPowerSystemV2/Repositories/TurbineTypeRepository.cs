using System.Linq;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;
using System.Reflection;

using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;

namespace WindPowerSystemV2.Repositories
{
	public class TurbineTypeRepository : BaseRepository<TurbineType>, ITurbineTypeRepository
	{
		public TurbineTypeRepository(Context dbContext) : base(dbContext)
		{
		}

		public override IQueryable<TurbineType> GetAll()
		{
			string oraConnection = @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1522))(CONNECT_DATA=(SERVER = DEDICATED)(SERVICE_NAME = WPS))); User Id=C##WPS; Password=82385770;";

			var cfg = new Configuration();

			cfg.DataBaseIntegration(x =>
			{
				x.ConnectionString = oraConnection;
				x.Driver<OracleManagedDataClientDriver>();
				x.Dialect<Oracle12cDialect>();
			});

			var assembly = Assembly.GetExecutingAssembly();

			cfg.AddAssembly(assembly);

			var sefact = cfg.BuildSessionFactory();

			using (var session = sefact.OpenSession())
			{
				using (var tx = session.BeginTransaction())
				{
					//var turbineType1 = new TurbineType { Model = "model5", Capacity = 555 };
					//session.Save(turbineType1);

					var turbineTypes = session.CreateCriteria<TurbineType>().List<TurbineType>();

					foreach (var type in turbineTypes)
					{
						dbSet.Add(type);
					}

					tx.Commit();
				}
			}

			return dbSet;
		}
	}
}
