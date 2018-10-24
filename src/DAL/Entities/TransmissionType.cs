using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
	/// <summary>
	/// TransmissionType entity.
	/// </summary>
	public class TransmissionType
	{
		/// <summary>
		/// Gets or sets the transmission type pk.
		/// </summary>
		[Key]
		public int TransmissionTypeId { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		[MaxLength(50)]
		public string Type { get; set; }
	}
}
