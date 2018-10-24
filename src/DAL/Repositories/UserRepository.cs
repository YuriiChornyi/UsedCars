using System;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
	public class UserRepository : IUserRepository
	{
		/// <summary>
		/// The database context
		/// </summary>
		private readonly UsedCarsDbContext _dbContext;

		public UserRepository(UsedCarsDbContext context)
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
			return _dbContext.Advertisement.Where(x => x.UserId == id).AsNoTracking();
		}

		public IQueryable<User> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<User> Get(Guid id)
		{
			throw new NotImplementedException();
		}

		public void Add(User item)
		{
			_dbContext.User.Add(item);
		}

		public SaveUpdateResult<User> AddAsync(User item)
		{
			var result = _dbContext.User.AddAsync(item).Result.Entity;
			var errorCode = _dbContext.SaveChanges() > 0 ? 1 : 2;
			return new SaveUpdateResult<User> {Result = result, ErrorCode = (ErrorCodeExtended) errorCode};
		}

		public void Remove(Guid id)
		{
			throw new NotImplementedException();
		}

		public User AddUser(User item)
		{
			return _dbContext.User.Add(item).Entity;
		}
	}
}