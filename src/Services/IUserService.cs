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
		/// <param name="userToAdd">The user to add.</param>
		/// <returns>Task</returns>
		SaveUpdateResult<User> AddUserAsync(User userToAdd);

		/// <summary>
		/// Removes the user.
		/// </summary>
		/// <param name="userToAdd">The user to add.</param>
		void RemoveUser(User userToAdd);
	}
}
