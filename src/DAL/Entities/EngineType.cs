using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
	/// <summary>
	/// EngineType Entity.
	/// </summary>
	public class EngineType
	{
		/// <summary>
		/// Gets or sets the engine type identifier.
		/// </summary>
		[Key]
		public int EngineTypeId { get; set; }

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		[MaxLength(50)]
		public string Type { get; set; }
	}
}