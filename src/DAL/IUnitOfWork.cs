using System;
using DAL.Entities;
using DAL.Repositories;

namespace DAL
{
	/// <summary>
	/// IUnitOfWork
	/// </summary>
	/// <seealso cref="System.IDisposable" />
	public interface IUnitOfWork : IDisposable
	{
		/// <summary>
		/// Gets the advertisement repository.
		/// </summary>
		IAdvertisementRepository AdvertisementRepository { get; }

		/// <summary>
		/// Gets the manufacturer repository.
		/// </summary>
		IRepository<Manufacturer> ManufacturerRepository { get; }

		/// <summary>
		/// Gets the model repository.
		/// </summary>
		IRepository<Model> ModelRepository { get; }

		/// <summary>
		/// Gets the user repository.
		/// </summary>
		IUserRepository UserRepository { get; }

		/// <summary>
		/// Commits all changes
		/// </summary>
		void Commit();
	}
}
