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

		protected BaseRepository(ISessionFactory sessionFactory)
		{
			_sessionFactory = sessionFactory;
			dbSet = Enumerable.Empty<T>().AsQueryable();
		}

		public virtual IQueryable<T> GetAll()
		{
			using (var session = _sessionFactory.OpenSession())
			{
				using (var transaction = session.BeginTransaction())
				{
					dbSet = session.CreateCriteria<T>().List<T>().AsQueryable();

					transaction.Commit();
				}
			}

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
			using (var session = _sessionFactory.OpenSession())
			{
				return session.CreateCriteria(typeof(T))
					.Add(Restrictions.Eq("Id", id)).UniqueResult<T>();
			}
		}

		public virtual void Create(T item)
		{
			using (var session = _sessionFactory.OpenSession())
			{
				using (var transaction = session.BeginTransaction())
				{
					session.Save(item);

					transaction.Commit();
				}
			}
		}

		//public virtual void Update(T item)
		//{
		//	dbContext.Entry(item).State = EntityState.Modified;
		//	dbContext.SaveChanges();
		//}

		//public virtual void Remove(T item)
		//{
		//	dbSet.Remove(item);
		//	dbContext.SaveChanges();
		//}
	}
}
