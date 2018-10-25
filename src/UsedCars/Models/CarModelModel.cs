namespace UsedCars.Models
{
	public class CarModelModel
	{
		/// <summary>
		/// Gets or sets the car model identifier.
		/// </summary>
		public int CarModelId { get; set; }

		/// <summary>
		/// Gets or sets the name of the model.
		/// </summary>
		public string CarModelName { get; set; }

		/// <summary>
		/// Gets or sets the manufacturer.
		/// </summary>
		public ManufacturerModel Manufacturer { get; set; }
	}
}
