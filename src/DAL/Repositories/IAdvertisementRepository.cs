using DAL.Entities;
using DAL.Helpers;
using AdvertisementD = DAL.DapperEntities.Advertisement;

namespace DAL.Repositories
{
	/// <summary>
	/// IAdvertisement Repository
	/// </summary>
	public interface IAdvertisementRepository : IRepository<Advertisement>
	{
		//IEnumerable<Advertisement> GetAdvertisementsPagedWithFilters(int pageIndex, int pageSize);
		ListDto<AdvertisementD> GetAdvertisementsPaged(int offset, int pageSize);

		ListDto<Advertisement> GetLazyAdvertisementsPaged(int offset, int pageSize);
	}
}
