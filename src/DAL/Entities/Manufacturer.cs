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
		/// Gets or sets the manufacturer pk.
		/// </summary>
		[Key]
		public int ManufacturerPK { get; set; }

		/// <summary>
		/// Gets or sets the name of the manufacturer.
		/// </summary>
		[MaxLength(50)]
		public string ManufacturerName { get; set; }

		/// <summary>
		/// Gets or sets the models.
		/// </summary>
		public virtual ICollection<Model> Models { get; set; }


	}
}
