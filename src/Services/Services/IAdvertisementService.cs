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
	}
}
