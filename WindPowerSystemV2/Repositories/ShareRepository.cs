using NHibernate;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;

namespace WindPowerSystemV2.Repositories
{
	public class ShareRepository : BaseRepository<Share>, IShareRepository
	{
		public ShareRepository(ISession session) : base(session)
		{
		}
	}
}
