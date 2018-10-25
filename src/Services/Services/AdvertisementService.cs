using DAL.Entities;
using DAL.Helpers;
using DAL.Repositories;

namespace Services.Services
{
	public class AdvertisementService:IAdvertisementService
	{
		private readonly IAdvertisementRepository _repository;

		/// <summary>
		/// Initializes a new instance of the <see cref="AdvertisementService"/> class.
		/// </summary>
		/// <param name="repository">The repository.</param>
		public AdvertisementService(IAdvertisementRepository repository)
		{
			_repository = repository;
		}

		public SaveUpdateResult<Advertisement> CreateAdvertisement(Advertisement advertisement) =>
			_repository.AddAsync(advertisement);
	}
}
