using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
	/// <summary>
	/// Model Entity
	/// </summary>
	public class Model
	{
		/// <summary>
		/// Gets or sets the model pk.
		/// </summary>
		[Key]
		public int ModelPK { get; set; }

		/// <summary>
		/// Gets or sets the name of the model.
		/// </summary>
		[MaxLength(50)]
		public string ModelName { get; set; }

		/// <summary>
		/// Gets or sets the manufacturer.
		/// </summary>
		public Manufacturer Manufacturer { get; set; }

		/// <summary>
		/// Gets or sets the manufacturer fk.
		/// </summary>

		[ForeignKey("Manufacturer")]
		public int ManufacturerFK { get; set; }
	}
}
