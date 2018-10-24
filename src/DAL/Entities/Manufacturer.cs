using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
	/// <summary>
	/// Manufacturer Entity
	/// </summary>
	public class Manufacturer
	{
		/// <summary>
		/// Gets or sets the manufacturer identifier.
		/// </summary>
		[Key]
		public int ManufacturerId { get; set; }

		/// <summary>
		/// Gets or sets the name of the manufacturer.
		/// </summary>
		[MaxLength(50)]
		public string ManufacturerName { get; set; }

		/// <summary>
		/// Gets or sets the car models.
		/// </summary>
		public virtual ICollection<CarModel> CarModels { get; set; }
	}
}
