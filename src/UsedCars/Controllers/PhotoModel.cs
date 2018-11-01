using System;

namespace UsedCars.Controllers
{
	public class PhotoModel
	{
		/// <summary>
		/// Gets or sets the photo pk.
		/// </summary>
		public int PhotoId { get; set; }

		/// <summary>
		/// Gets or sets the photo URL.
		/// </summary>
		public string PhotoURL { get; set; }

		/// <summary>
		/// Gets or sets the advertisement identifier.
		/// </summary>
		public Guid AdvertisementId { get; set; }
	}
}
