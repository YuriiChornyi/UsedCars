namespace UsedCars.Models
{
	public class TransmissionModel
	{
		/// <summary>
		/// Gets or sets the transmission type pk.
		/// </summary>
		public int TransmissionId { get; set; }

		/// <summary>
		/// Gets or sets the type of the gear box.
		/// </summary>
		public GearBoxTypeModel GearBoxType { get; set; }
		
		/// <summary>
		/// Gets or sets the type of the transmission.
		/// </summary>
		public TransmissionTypeModel TransmissionType { get; set; }
	}
}
