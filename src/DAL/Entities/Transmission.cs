using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
	/// <summary>
	/// Transmission Entity
	/// </summary>
	public class Transmission
	{
		/// <summary>
		/// Gets or sets the transmission type pk.
		/// </summary>
		[Key]
		public int TransmissionId { get; set; }

		/// <summary>
		/// Gets or sets the type of the gear box.
		/// </summary>
		public virtual GearBoxType GearBoxType { get; set; }

		/// <summary>
		/// Gets or sets the gear box type identifier.
		/// </summary>
		[ForeignKey("GearBoxType")]
		public int GearBoxTypeId { get; set; }

		/// <summary>
		/// Gets or sets the type of the transmission.
		/// </summary>
		public virtual TransmissionType TransmissionType { get; set; }

		/// <summary>
		/// Gets or sets the transmission type identifier.
		/// </summary>
		[ForeignKey("TransmissionType")]
		public int TransmissionTypeId { get; set; }

	}
}
