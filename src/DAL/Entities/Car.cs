﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
	/// <summary>
	/// Car Entity
	/// </summary>
	public class Car
	{
		/// <summary>
		/// Gets or sets the car identifier.
		/// </summary>
		public Guid CarId { get; set; }

		/// <summary>
		/// Gets or sets the engine.
		/// </summary>
		public virtual Engine Engine { get; set; }

		/// <summary>
		/// Gets or sets the engine identifier.
		/// </summary>
		[ForeignKey("Engine")]
		public int EngineId { get; set; }

		/// <summary>
		/// Gets or sets the transmission.
		/// </summary>
		public virtual Transmission Transmission { get; set; }

		/// <summary>
		/// Gets or sets the transmission identifier.
		/// </summary>
		[ForeignKey("Transmission")]
		public int TransmissionId { get; set; }

		/// <summary>
		/// Gets or sets the car model.
		/// </summary>
		public virtual CarModel CarModel { get; set; }

		/// <summary>
		/// Gets or sets the car model identifier.
		/// </summary>
		[ForeignKey("CarModel")]
		public int CarModelId { get; set; }

		/// <summary>
		/// Gets or sets the advertisement.
		/// </summary>
		public virtual Advertisement Advertisement { get; set; }

		/// <summary>
		/// Gets or sets the advertisement identifier.
		/// </summary>
		[ForeignKey("Advertisement")]
		public Guid AdvertisementId { get; set; }

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
