using System;

namespace UsedCars.Models
{
	public class UserModel
	{
		/// <summary>
		/// Gets or sets the user pk.
		/// </summary>
		public Guid UserPK { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the registration date.
		/// </summary>
		public DateTime? RegistrationDate { get; set; }

		/// <summary>
		/// Gets or sets the email.
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Gets or sets the phone.
		/// </summary>
		public string Phone { get; set; }
	}
}