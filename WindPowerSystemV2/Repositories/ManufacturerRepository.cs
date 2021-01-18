using NHibernate;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;

namespace WindPowerSystemV2.Repositories
{
	public class ManufacturerRepository : BaseRepository<Manufacturer>, IManufacturerRepository
	{
		public ManufacturerRepository(ISession session) : base(session)
		{
		}
	}
}
