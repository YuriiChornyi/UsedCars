using System;
using System.Linq;
using DAL.Entities;

namespace DAL.Repositories
{
	/// <summary>
	/// IUserRepository
	/// </summary>
	public interface IUserRepository: IRepository<User>
	{
		/// <summary>
		/// Gets the user advertisements.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns>Advertisements by user</returns>
		IQueryable<Advertisement> GetUserAdvertisements(Guid id);
	}
}
