using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
	/// <summary>
	/// Model Entity
	/// </summary>
	public class CarModel
	{
		/// <summary>
		/// Gets or sets the model identifier.
		/// </summary>
		[Key]
		public int CarModelId { get; set; }

		/// <summary>
		/// Gets or sets the name of the model.
		/// </summary>
		[MaxLength(50)]
		public string CarModelName { get; set; }

		/// <summary>
		/// Gets or sets the manufacturer.
		/// </summary>
		public virtual Manufacturer Manufacturer { get; set; }

		/// <summary>
		/// Gets or sets the manufacturer identifier.
		/// </summary>
		[ForeignKey("Manufacturer")]
		public int ManufacturerId { get; set; }
	}
}
