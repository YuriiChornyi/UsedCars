using System.Collections.Generic;
using DAL.Entities;
using DAL.Helpers;

namespace Services.Services
{
	public interface IAdvertisementService
	{
		/// <summary>
		/// Creates the advertisement.
		/// </summary>
		/// <param name="advertisement">The advertisement.</param>
		/// <returns>SaveUpdateResult</returns>
		SaveUpdateResult<Advertisement> CreateAdvertisement(Advertisement advertisement);

		ListDto<DAL.DapperEntities.Advertisement> GetAdvertisementsPaged(int offset, int pageSize);
		//ListDto<Advertisement> GetAdvertisementsPaged(int offset, int pageSize);
	}
}
