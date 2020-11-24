using System;
using System.Linq;
using System.Linq.Expressions;

namespace WindPowerSystemV2.Repositories.Interfaces
{
	public interface IBaseRepository<T> where T : class
	{
		IQueryable<T> GetAll();
		IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
		IQueryable<T> Get(Expression<Func<T, bool>> predicate);

		T FindById(int id);

		void Create(T item);
		void Update(T item);
		void Remove(T item);
	}
}
