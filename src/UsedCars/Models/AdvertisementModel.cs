using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsedCars.Models
{
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
		public Guid CarId { get; set; }

		/// <summary>
		/// Gets or sets the price.
		/// </summary>
		public double Price { get; set; }
	}
}
