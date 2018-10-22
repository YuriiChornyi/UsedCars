using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
	/// <summary>
	/// User Entity
	/// </summary>
	public class User
	{
		/// <summary>
		/// Gets or sets the user pk.
		/// </summary>
		[Key]
		public Guid UserPK { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		[MaxLength(50)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the registration date.
		/// </summary>
		public DateTime RegistrationDate { get; set; }

		/// <summary>
		/// Gets or sets the email.
		/// </summary>
		[MaxLength(50)]
		public string Email { get; set; }

		/// <summary>
		/// Gets or sets the phone.
		/// </summary>
		[MaxLength(50)]
		public string Phone { get; set; }
	}
}
