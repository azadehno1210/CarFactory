using Contracts.IServices;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Repositories
{
	public abstract class RepositoryBase<T> : IRepositoryBase<T> where T
: class
	{
		protected CarFactoryContext _carFactoryContext;
		public RepositoryBase(CarFactoryContext carFactoryContext)
		{
			_carFactoryContext = carFactoryContext;
		}
		public IQueryable<T> FindAll(bool trackChanges) =>
		!trackChanges ?
		_carFactoryContext.Set<T>().AsNoTracking() :
		_carFactoryContext.Set<T>();
		public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) => !trackChanges ? _carFactoryContext.Set<T>() .Where(expression) .AsNoTracking() :
		_carFactoryContext.Set<T>()
		.Where(expression);
		public void Create(T entity) => _carFactoryContext.Set<T>().Add(entity);
		public void Update(T entity) => _carFactoryContext.Set<T>().Update(entity);
		public void Delete(T entity) => _carFactoryContext.Set<T>().Remove(entity);
	}
}


