using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UsedCars.Models
{
	[JsonObject]
	public class AdvertisementModel
	{
		/// <summary>
		/// Gets or sets the advertisement pk.
		/// </summary>
		public Guid AdvertisementId { get; set; }

		/// <summary>
		/// Gets or sets the user fk.
		/// </summary>
		public Guid UserId { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the car identifier.
		/// </summary>
		public CarModel Car { get; set; }

		/// <summary>
		/// Gets or sets the price.
		/// </summary>
		public double Price { get; set; }

		/// <summary>
		/// Gets or sets the photos.
		/// </summary>
		public List<PhotoModel> Photos { get; set; }
	}
}
