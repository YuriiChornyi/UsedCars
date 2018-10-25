using System;

namespace UsedCars.Models
{
	public class CarModel
	{
		/// <summary>
		/// Gets or sets the car identifier.
		/// </summary>
		public Guid CarId { get; set; }

		/// <summary>
		/// Gets or sets the engine.
		/// </summary>
		public EngineModel Engine { get; set; }

		/// <summary>
		/// Gets or sets the transmission.
		/// </summary>
		public TransmissionModel Transmission { get; set; }

		/// <summary>
		/// Gets or sets the car model.
		/// </summary>
		public CarModelModel CarModelModel { get; set; }

		/// <summary>
		/// Gets or sets the production year.
		/// </summary>
		public DateTime? ProductionYear { get; set; }

		/// <summary>
		/// Gets or sets the vin code.
		/// </summary>
		public string VinCode { get; set; }
	}
}
