using NHibernate;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;

namespace WindPowerSystemV2.Repositories
{
	public class ShareHolderRepository : BaseRepository<ShareHolder>, IShareHolderRepository
	{
		public ShareHolderRepository(ISession session) : base(session)
		{
		}
	}
}
