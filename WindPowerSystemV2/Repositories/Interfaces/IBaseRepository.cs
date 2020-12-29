using NHibernate;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace WindPowerSystemV2.Repositories.Interfaces
{
	public interface IBaseRepository<T> where T : class
	{
		IQueryable<T> GetAll(ISession session);
		//IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
		//IQueryable<T> Get(Expression<Func<T, bool>> predicate);

		T FindById(int id, ISession session);

		void Create(T item, ISession session);
		void Update(T item, ISession session);
		void Remove(T item, ISession session);
	}
}
