using NHibernate;
using NHibernate.Criterion;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;

namespace WindPowerSystemV2.Repositories
{
	public class UserRepository : BaseRepository<User>, IUserRepository
	{
		public UserRepository(ISession session) : base(session)
		{
		}

		public User FindByGuid(string id)
		{
			User userDB = _session.CreateCriteria(typeof(User))
				.Add(Restrictions.Eq("Id", id)).UniqueResult<User>();

			return userDB;
		}
	}
}
