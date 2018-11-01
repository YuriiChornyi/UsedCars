using System;
using Newtonsoft.Json;

namespace UsedCars.Models
{
	[JsonObject]
	public class CarModel
	{
		/// <summary>
		/// Gets or sets the car identifier.
		/// </summary>
		public Guid CarId { get; set; }

		/// <summary>
		/// Gets or sets the advertisement identifier.
		/// </summary>
		public Guid AdvertisementId { get; set; }

		/// <summary>
		/// Gets or sets the engine.
		/// </summary>
		public int EngineId { get; set; }

		/// <summary>
		/// Gets or sets the transmission.
		/// </summary>
		public int TransmissionId { get; set; }

		/// <summary>
		/// Gets or sets the car model.
		/// </summary>
		public int CarModelId { get; set; }

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
