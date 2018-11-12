using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
	/// <summary>
	/// Photo model.
	/// </summary>
	public class Photo
	{
		/// <summary>
		/// Gets or sets the photo pk.
		/// </summary>
		[Key]
		public int PhotoId { get; set; }

		/// <summary>
		/// Gets or sets the photo URL.
		/// </summary>
		public string PhotoName { get; set; }

		/// <summary>
		/// Gets or sets the advertisement.
		/// </summary>
		public virtual Advertisement Advertisement { get; set; }

		/// <summary>
		/// Gets or sets the advertisement identifier.
		/// </summary>
		[ForeignKey("Advertisement")]
		public Guid AdvertisementId { get; set; }
	}
}
