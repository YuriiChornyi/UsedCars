using System;
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
		public Guid AdvertisementPK { get; set; }

		/// <summary>
		/// Gets or sets the user.
		/// </summary>
		public User User { get; set; }

		/// <summary>
		/// Gets or sets the user fk.
		/// </summary>
		[ForeignKey("User")]
		public Guid UserFK { get; set; }

		/// <summary>
		/// Gets or sets the model.
		/// </summary>
		public Model Model { get; set; }

		/// <summary>
		/// Gets or sets the model fk.
		/// </summary>
		[ForeignKey("Model")]
		public int ModelFK { get; set; }

		/// <summary>
		/// Gets or sets the description.
		/// </summary>
		[MaxLength(500)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or sets the production year.
		/// </summary>
		public DateTime ProductionYear { get; set; }

		/// <summary>
		/// Gets or sets the price.
		/// </summary>
		public double Price { get; set; }
	}
}
