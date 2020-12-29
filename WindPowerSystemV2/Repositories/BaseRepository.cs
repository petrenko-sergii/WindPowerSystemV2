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
		protected IQueryable<T> dbSet;

		protected BaseRepository(ISessionFactory sessionFactory)
		{
			dbSet = Enumerable.Empty<T>().AsQueryable();
		}

		public virtual IQueryable<T> GetAll(ISession session)
		{
			dbSet = session.CreateCriteria<T>().List<T>().AsQueryable();

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

		public virtual T FindById(int id, ISession session)
		{
			T dbItem = session.CreateCriteria(typeof(T))
				.Add(Restrictions.Eq("Id", id)).UniqueResult<T>();

			return dbItem;
		}

		public virtual void Create(T item, ISession session)
		{
			using (var transaction = session.BeginTransaction())
			{
				session.Save(item);
				transaction.Commit();
			}
		}

		public virtual void Update(T item, ISession session)
		{
			using (var transaction = session.BeginTransaction())
			{
				session.Update(item);
				transaction.Commit();
			}
		}

		public virtual void Remove(T item, ISession session)
		{
			using (var transaction = session.BeginTransaction())
			{
				session.Delete(item);
				transaction.Commit();
			}
		}
	}
}
