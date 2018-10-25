using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entities;

namespace Services.Services
{
	public class ManufacturerService : IManufacturerService
	{
		/// <summary>
		/// The repository
		/// </summary>
		private readonly IRepository<Manufacturer> _repository;

		/// <summary>
		/// Initializes a new instance of the <see cref="ManufacturerService"/> class.
		/// </summary>
		/// <param name="repository">The repository.</param>
		public ManufacturerService(IRepository<Manufacturer> repository)
		{
			_repository = repository;
		}
		public List<Manufacturer> GetManufacturers()
		{
			return _repository.GetAll().ToList();
		}

		public List<CarModel> GetCarModelsByManufacturerId(int manufacturerId)
		{
			return _repository.GetById(manufacturerId).CarModels.ToList();
		}
	}
}
