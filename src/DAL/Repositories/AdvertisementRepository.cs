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
		/// Initializes a new instance of the <see cref="AdvertisementRepository"/> class.
		/// </summary>
		public AdvertisementRepository()
		{

		}

		public void Add(Advertisement item)
		{
			throw new NotImplementedException();
		}

		public SaveUpdateResult<Advertisement> AddAsync(Advertisement item)
		{
			throw new NotImplementedException();
		}

		public Task<Advertisement> Get(Guid id)
		{
			throw new NotImplementedException();
		}

		public IQueryable<Advertisement> GetAll()
		{
			throw new NotImplementedException();
		}

		public void Remove(Guid id)
		{
			throw new NotImplementedException();
		}
	}
}