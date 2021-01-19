using NHibernate;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models.ImageModels;

namespace WindPowerSystemV2.Repositories
{
	public class AppImageRepository : BaseRepository<AppImage>, IAppImageRepository
	{
		public AppImageRepository(ISession session) : base(session)
		{
		}
	}
}
