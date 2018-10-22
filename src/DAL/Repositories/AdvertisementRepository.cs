using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
	public class AdvertisementRepository : GenericRepository<AdvertisementRepository>, IAdvertisementRepository
	{
		/// <summary>
		/// The database context
		/// </summary>
		private readonly UsedCarsDbContext _dbContext;

		/// <summary>
		/// Initializes a new instance of the <see cref="AdvertisementRepository"/> class.
		/// </summary>
		/// <param name="context">The context.</param>
		public AdvertisementRepository(UsedCarsDbContext context) : base(context)
		{
			_dbContext = context;
		}

		/// <summary>
		/// Gets the by manufacturer.
		/// </summary>
		/// <param name="manufacturerId">The manufacturer identifier.</param>
		/// <returns>Advertisements by Manufacturer</returns>
		public IEnumerable<Advertisement> GetByManufacturer(int manufacturerId)
		{
			return _dbContext.Advertisements.Where(x => x.Model.ManufacturerFK == manufacturerId).AsNoTracking();
		}

		/// <summary>
		/// Gets the by model.
		/// </summary>
		/// <param name="modelId">The model identifier.</param>
		/// <returns>Advertisements by Manufacturer</returns>
		public IEnumerable<Advertisement> GetByModel(int modelId)
		{
			return _dbContext.Advertisements.Where(x => x.ModelFK == modelId).AsNoTracking();
		}

		/// <summary>
		/// Gets the by production year.
		/// </summary>
		/// <param name="year">The year.</param>
		/// <returns>Advertisements by Prod year</returns>
		public IEnumerable<Advertisement> GetByProductionYear(DateTime year)
		{
			return _dbContext.Advertisements.Where(x => x.ProductionYear.Year == year.Year).AsNoTracking();
		}
	}
}