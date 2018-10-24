using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
	/// <summary>
	/// Engine Entity
	/// </summary>
	public class Engine
	{
		/// <summary>
		/// Gets or sets the engine identifier.
		/// </summary>
		[Key]
		public int EngineId { get; set; }

		/// <summary>
		/// Gets or sets the type of the engine.
		/// </summary>
		public EngineType EngineType { get; set; }

		/// <summary>
		/// Gets or sets the engine type identifier.
		/// </summary>
		[ForeignKey("EngineType")]
		public int EngineTypeId { get; set; }

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
