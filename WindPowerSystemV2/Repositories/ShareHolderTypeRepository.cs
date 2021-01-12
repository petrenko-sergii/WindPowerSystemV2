using NHibernate;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;

namespace WindPowerSystemV2.Repositories
{
	public class ShareHolderTypeRepository : BaseRepository<ShareHolderType>, IShareHolderTypeRepository
	{
		public ShareHolderTypeRepository(ISession session) : base(session)
		{
		}
	}
}
