using System.Collections.Generic;
using DAL.Entities;

namespace Services.Services
{
	/// <summary>
	/// IManufacturerService
	/// </summary>
	public interface IManufacturerService
	{
		/// <summary>
		/// Gets the manufacturer models.
		/// </summary>
		/// <returns>List<Manufacturer></returns>
		List<Manufacturer> GetManufacturers();

		/// <summary>
		/// Gets the car models by manufacturer identifier.
		/// </summary>
		/// <param name="manufacturerId">The manufacturer identifier.</param>
		/// <returns>List<CarModel></returns>
		List<CarModel> GetCarModelsByManufacturerId(int manufacturerId);
	}
}
