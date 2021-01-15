using NHibernate;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models.AddressModels;

namespace WindPowerSystemV2.Repositories
{
	public class AddressRepository : BaseRepository<Address>, IAddressRepository
	{
		public AddressRepository(ISession session) : base(session)
		{
		}
	}
}
