using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
	/// <summary>
	/// Advertisement Entity
	/// </summary>
	public class Advertisement
	{
		/// <summary>
		/// Gets or sets the advertisement pk.
		/// </summary>
		[Key]
		public Guid AdvertisementId { get; set; }

		/// <summary>
		/// Gets or sets the user.
		/// </summary>
		public virtual User User { get; set; }

		/// <summary>
		/// Gets or sets the user fk.
		/// </summary>
		[ForeignKey("User")]
		public Guid UserId { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		[MaxLength(500)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the car.
		/// </summary>
		public virtual Car Car { get; set; }

		/// <summary>
		/// Gets or sets the price.
		/// </summary>
		public double Price { get; set; }

		/// <summary>
		/// Gets or sets the i collection`1.
		/// </summary>
		public virtual ICollection<Photo> Photos { get; set; }
	}
}
