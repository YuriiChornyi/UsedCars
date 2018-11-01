using System.Collections.Generic;
using System.Linq;
using DAL;
using DAL.Entities;
using DAL.Helpers;
using DAL.Repositories;
using AdvertisementD = DAL.DapperEntities.Advertisement;

namespace Services.Services
{
	public class AdvertisementService : IAdvertisementService
	{
		private readonly IAdvertisementRepository _repository;

		private readonly IRepository<Car> _carRepository;

		/// <summary>
		/// Initializes a new instance of the <see cref="AdvertisementService"/> class.
		/// </summary>
		/// <param name="repository">The repository.</param>
		public AdvertisementService(IAdvertisementRepository repository, IRepository<Car> carRepository)
		{
			_repository = repository;
			_carRepository = carRepository;
		}

		public SaveUpdateResult<Advertisement> CreateAdvertisement(Advertisement advertisement)
		{
			var res = _repository.AddAsync(advertisement);
			advertisement.Car.AdvertisementId = res.Result.AdvertisementId;
			_carRepository.Add(advertisement.Car);
			return res;
		}

		public ListDto<AdvertisementD> GetAdvertisementsPaged(int offset, int pageSize) =>
			_repository.GetAdvertisementsPaged(offset, pageSize);
	}
}
