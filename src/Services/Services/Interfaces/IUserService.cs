using System.Threading.Tasks;
using DAL.Entities;
using DAL.Helpers;

namespace Services
{
	/// <summary>
	/// IUserService
	/// </summary>
	public interface IUserService
	{
		/// <summary>
		/// Adds the user asynchronous.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="email"></param>
		/// <param name="phone"></param>
		/// <returns>Task</returns>
		SaveUpdateResult<User> AddUserAsync(string name, string email, string phone);

		/// <summary>
		/// Removes the user.
		/// </summary>
		/// <param name="userToAdd">The user to add.</param>
		void RemoveUser(User userToAdd);
	}
}
