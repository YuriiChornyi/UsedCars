using System;
using System.Linq;
using System.Threading.Tasks;
using DAL.Helpers;
using Microsoft.EntityFrameworkCore;

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
			return _dbContext.Set<T>().AsNoTracking();
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
			_dbContext.Set<T>().AddAsync(item);
		}

		public SaveUpdateResult<T> AddAsync(T item)
		{
			throw new NotImplementedException();
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