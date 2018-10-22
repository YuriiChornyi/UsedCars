using System;
using System.Linq;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
	public class UserRepository : GenericRepository<User>, IUserRepository
	{
		/// <summary>
		/// The database context
		/// </summary>
		private readonly UsedCarsDbContext _dbContext;

		public UserRepository(UsedCarsDbContext context) : base(context)
		{
			_dbContext = context;
		}

		/// <summary>
		/// Gets the user advertisements.
		/// </summary>
		/// <param name="id">The identifier.</param>
		/// <returns>Advertisements by user</returns>
		public IQueryable<Advertisement> GetUserAdvertisements(Guid id)
		{
			return _dbContext.Advertisements.Where(x => x.UserFK == id).AsNoTracking();
		}
	}
}
