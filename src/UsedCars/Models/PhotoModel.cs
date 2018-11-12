using System;

namespace UsedCars.Models
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
		public string PhotoName { get; set; }

		/// <summary>
		/// Gets or sets the advertisement identifier.
		/// </summary>
		public Guid AdvertisementId { get; set; }
	}
}
