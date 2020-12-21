using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using WindPowerSystemV2.Repositories.Interfaces;
using WindPowerSystemV2.Repositories.Models;

namespace WindPowerSystemV2.Repositories
{
	public class BaseRepository<T> : IBaseRepository<T> where T : class
	{
		private readonly ISessionFactory _sessionFactory;
		protected IQueryable<T> dbSet;
		ISession _session;

		protected BaseRepository(ISessionFactory sessionFactory)
		{
			_sessionFactory = sessionFactory;
			dbSet = Enumerable.Empty<T>().AsQueryable();
			_session = _sessionFactory.OpenSession();
		}

		public virtual IQueryable<T> GetAll()
		{
			dbSet = _session.CreateCriteria<T>().List<T>().AsQueryable();

			_session.Dispose();
			return dbSet;
		}

		//public virtual IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
		//{
		//	return dbSet.Where(predicate).AsNoTracking();
		//}

		//public virtual IQueryable<T> Get(Expression<Func<T, bool>> predicate)
		//{
		//	return dbSet.Where(predicate);
		//}

		public virtual T FindById(int id)
		{
			T dbItem = _session.CreateCriteria(typeof(T))
				.Add(Restrictions.Eq("Id", id)).UniqueResult<T>();

			_session.Dispose();

			return dbItem;
		}

		public virtual void Create(T item)
		{
			using (var transaction = _session.BeginTransaction())
			{
				_session.Save(item);

				transaction.Commit();
			}

			_session.Dispose();
		}

		public virtual void Update(T item)
		{
			using (var transaction = _session.BeginTransaction())
			{
				_session.Update(item);
				transaction.Commit();
			}

			_session.Dispose();
		}

		//public virtual void Remove(T item)
		//{
		//	dbSet.Remove(item);
		//	dbContext.SaveChanges();
		//}
	}
}
