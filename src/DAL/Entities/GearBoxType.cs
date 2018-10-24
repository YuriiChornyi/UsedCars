using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
	/// <summary>
	/// GearBoxType Entity
	/// </summary>
	public class GearBoxType
	{
		/// <summary>
		/// Gets or sets the transmission type pk.
		/// </summary>
		[Key]
		public int GearBoxTypeId { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		[MaxLength(50)]
		public string Type { get; set; }
	}
}
