using System;
using DAL.Entities;
using DAL.Repositories;

namespace DAL
{
	public class UnitOfWork : IUnitOfWork
	{
		/// <summary>
		/// The disposed
		/// </summary>
		private bool _disposed;

		/// <summary>
		/// The database context
		/// </summary>
		private readonly UsedCarsDbContext _dbContext;

		/// <summary>
		/// Initializes a new instance of the <see cref="UnitOfWork"/> class.
		/// </summary>
		/// <param name="context">The context.</param>
		public UnitOfWork(UsedCarsDbContext context)
		{
			_dbContext = context;
		}

		/// <summary>
		/// Gets the advertisement repository.
		/// </summary>
		public IAdvertisementRepository AdvertisementRepository => new AdvertisementRepository(_dbContext);

		/// <summary>
		/// Gets the manufacturer repository.
		/// </summary>
		public IRepository<Manufacturer> ManufacturerRepository => new GenericRepository<Manufacturer>(_dbContext);

		/// <summary>
		/// Gets the model repository.
		/// </summary>
		public IRepository<Model> ModelRepository => new GenericRepository<Model>(_dbContext);

		/// <summary>
		/// Gets the user repository.
		/// </summary>
		public IUserRepository UserRepository => new UserRepository(_dbContext);

		/// <summary>
		/// Commits all changes
		/// </summary>
		public void Commit()
		{
			_dbContext.SaveChanges();
		}

		/// <summary>
		/// Releases unmanaged and - optionally - managed resources.
		/// </summary>
		/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
		public virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{
					_dbContext.Dispose();
				}

				_disposed = true;
			}
		}

		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

	}
}
