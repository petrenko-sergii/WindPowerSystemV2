﻿using NHibernate;
using NHibernate.Criterion;
using System.Linq;
using WindPowerSystemV2.Repositories.Interfaces;

namespace WindPowerSystemV2.Repositories
{
	public class BaseRepository<T> : IBaseRepository<T> where T : class
	{
		protected readonly ISession _session;
		protected IQueryable<T> dbSet;

		protected BaseRepository(ISession session)
		{
			_session = session;
		}

		public virtual IQueryable<T> GetAll()
		{
			dbSet = _session.CreateCriteria<T>().List<T>().AsQueryable();

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

			return dbItem;
		}

		public virtual void Create(T item)
		{
			using (var transaction = _session.BeginTransaction())
			{
				_session.Save(item);
				transaction.Commit();
			}
		}

		public virtual void Update(T item)
		{
			using (var transaction = _session.BeginTransaction())
			{
				_session.Update(item);
				transaction.Commit();
			}
		}

		public virtual void Remove(T item)
		{
			using (var transaction = _session.BeginTransaction())
			{
				_session.Delete(item);
				transaction.Commit();
			}
		}
	}
}
