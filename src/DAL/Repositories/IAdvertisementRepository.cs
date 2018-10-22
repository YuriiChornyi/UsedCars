using System;
using System.Collections.Generic;
using DAL.Entities;

namespace DAL.Repositories
{
	/// <summary>
	/// IAdvertisement Repository
	/// </summary>
	public interface IAdvertisementRepository
	{
		/// <summary>
		/// Gets the by manufacturer.
		/// </summary>
		/// <param name="manufacturerId">The manufacturer identifier.</param>
		/// <returns>Advertisements by Manufacturer</returns>
		IEnumerable<Advertisement> GetByManufacturer(int manufacturerId);

		/// <summary>
		/// Gets the by model.
		/// </summary>
		/// <param name="modelId">The model identifier.</param>
		/// <returns>Advertisements by model</returns>
		IEnumerable<Advertisement> GetByModel(int modelId);

		/// <summary>
		/// Gets the by production year.
		/// </summary>
		/// <param name="year">The year.</param>
		/// <returns>Advertisements by Prod year</returns>
		IEnumerable<Advertisement> GetByProductionYear(DateTime year);
	}
}
