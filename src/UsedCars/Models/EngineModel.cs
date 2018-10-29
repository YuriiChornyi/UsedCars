using Newtonsoft.Json;

namespace UsedCars.Models
{
	/// <summary>
	/// EngineModel
	/// </summary>
	[JsonObject]
	public class EngineModel
	{
		/// <summary>
		/// Gets or sets the engine identifier.
		/// </summary>
		public int EngineId { get; set; }

		/// <summary>
		/// Gets or sets the type of the engine.
		/// </summary>
		public virtual EngineTypeModel EngineType { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		public string Value { get; set; }

		/// <summary>
		/// Gets or sets the hp.
		/// </summary>
		public int HP { get; set; }
	}
}
