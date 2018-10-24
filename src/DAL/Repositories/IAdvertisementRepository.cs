using System;
using System.Collections.Generic;
using DAL.Entities;

namespace DAL.Repositories
{
	/// <summary>
	/// IAdvertisement Repository
	/// </summary>
	public interface IAdvertisementRepository : IRepository<Advertisement>
	{
		//IEnumerable<Advertisement> GetAdvertisementsPagedWithFilters(int pageIndex, int pageSize);
	}
}
