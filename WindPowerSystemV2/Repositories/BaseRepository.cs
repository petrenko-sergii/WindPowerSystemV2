using Microsoft.EntityFrameworkCore;
using NHibernate;
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
		private readonly ISessionFactory sessionFactory;
		protected IQueryable<T> dbSet;

		protected BaseRepository(ISessionFactory sessionFactory)
		{
			this.sessionFactory = sessionFactory;
			this.dbSet = Enumerable.Empty<T>().AsQueryable();
		}

		public virtual IQueryable<T> GetAll()
		{
			return dbSet.AsQueryable();
		}

		//public virtual IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
		//{
		//	return dbSet.Where(predicate).AsNoTracking();
		//}

		//public virtual IQueryable<T> Get(Expression<Func<T, bool>> predicate)
		//{
		//	return dbSet.Where(predicate);
		//}

		//public virtual T FindById(int id)
		//{
		//	return dbSet.Find(id);
		//}

		//public virtual void Create(T item)
		//{
		//	dbSet.Add(item);
		//	dbContext.SaveChanges();
		//}

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
