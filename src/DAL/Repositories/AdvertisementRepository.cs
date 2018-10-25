using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Helpers;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
	public class AdvertisementRepository : IAdvertisementRepository
	{
		/// <summary>
		/// The database context
		/// </summary>
		private readonly UsedCarsDbContext _dbContext;

		/// <summary>
		/// Initializes a new instance of the <see cref="AdvertisementRepository"/> class.
		/// </summary>
		public AdvertisementRepository(UsedCarsDbContext context)
		{
			_dbContext = context;
		}

		public Advertisement GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Add(Advertisement item)
		{
			throw new NotImplementedException();
		}

		public SaveUpdateResult<Advertisement> AddAsync(Advertisement item)
		{
			var result = _dbContext.Advertisement.AddAsync(item).Result.Entity;
			var errorCode = _dbContext.SaveChanges() > 0 ? 1 : 2;
			return new SaveUpdateResult<Advertisement> { Result = result, ErrorCode = (ErrorCodeExtended)errorCode };
		}

		public Task<Advertisement> Get(Guid id)
		{
			throw new NotImplementedException();
		}

		public IQueryable<Advertisement> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<Advertisement> GetByGuid(Guid id)
		{
			throw new NotImplementedException();
		}

		public void Remove(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}