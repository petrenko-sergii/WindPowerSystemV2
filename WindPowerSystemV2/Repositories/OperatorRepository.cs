using NHibernate;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;

namespace WindPowerSystemV2.Repositories
{
	public class OperatorRepository : BaseRepository<Operator>, IOperatorRepository
	{
		public OperatorRepository(ISession session) : base(session)
		{
		}
	}
}
