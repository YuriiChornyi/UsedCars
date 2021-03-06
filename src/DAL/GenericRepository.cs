﻿using System;
using System.Linq;
using System.Threading.Tasks;
using DAL.Helpers;

namespace DAL
{
	/// <summary>
	/// GenericRepository
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <seealso cref="DAL.IRepository{T}" />
	public class GenericRepository<T> : IRepository<T> where T : class
	{
		/// <summary>
		/// The database context
		/// </summary>
		private readonly UsedCarsDbContext _dbContext;

		/// <summary>
		/// Initializes a new instance of the <see cref="GenericRepository{T}"/> class.
		/// </summary>
		/// <param name="context">The context.</param>
		public GenericRepository(UsedCarsDbContext context)
		{
			_dbContext = context;
		}

		/// <summary>
		/// Gets all.
		/// </summary>
		/// <returns>IQueryable All</returns>
		public IQueryable<T> GetAll()
		{
			return _dbContext.Set<T>();
		}

		public Task<T> GetByGuid(Guid id)
		{
			return _dbContext.Set<T>().FindAsync(id);
		}

		public T GetById(int id)
		{
			return _dbContext.Set<T>().Find(id);
		}

		/// <summary>
		/// Gets the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns>Entity by Id</returns>
		public Task<T> Get(Guid id)
		{
			return _dbContext.Set<T>().FindAsync(id);
		}

		/// <summary>
		/// Adds item.
		/// </summary>
		/// <param name="item"></param>
		public void Add(T item)
		{
			_dbContext.Set<T>().Add(item);
			_dbContext.SaveChanges();
		}

		public SaveUpdateResult<T> AddAsync(T item)
		{
			var res=_dbContext.Set<T>().AddAsync(item);
			var errorCode = _dbContext.SaveChanges() > 0 ? 1 : 2;

			return new SaveUpdateResult<T>() {Result = res.Result.Entity, ErrorCode = (ErrorCodeExtended) errorCode};

		}

		/// <summary>
		/// Removes the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		public void Remove(Guid id)
		{
			var itemToRemove = _dbContext.Set<T>().Find(id);
			_dbContext.Set<T>().Remove(itemToRemove);
		}
	}
}