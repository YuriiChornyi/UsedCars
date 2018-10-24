using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Helpers;

namespace DAL
{
	/// <summary>
	/// IRepository
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IRepository<T> where T: class
	{
		/// <summary>
		/// Gets all.
		/// </summary>
		IQueryable<T> GetAll();

		/// <summary>
		/// Gets the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		Task<T> Get(Guid id);

		/// <summary>
		/// Adds the specified item.
		/// </summary>
		/// <param name="item">The item.</param>
		void Add(T item);

		/// <summary>
		/// Adds the asynchronous.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>Task</returns>
		SaveUpdateResult<T> AddAsync(T item);

		/// <summary>
		/// Removes the specified identifier.
		/// </summary>
		/// <param name="id">The identifier.</param>
		void Remove(Guid id);
	}
}