using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
	/// <summary>
	/// UsedCars DbContext
	/// </summary>
	/// <seealso cref="DbContext" />
	public class UsedCarsDbContext : DbContext
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UsedCarsDbContext"/> class.
		/// </summary>
		/// <param name="options">The options for this context.</param>
		public UsedCarsDbContext(DbContextOptions options) : base(options)
		{
		}

		/// <summary>
		/// Gets or sets the advertisements.
		/// </summary>>
		public DbSet<Advertisement> Advertisements { get; set; }

		/// <summary>
		/// Gets or sets the manufacturers.
		/// </summary>
		public DbSet<Manufacturer> Manufacturers { get; set; }

		/// <summary>
		/// Gets or sets the models.
		/// </summary>
		public DbSet<Model> Models { get; set; }

		/// <summary>
		/// Gets or sets the users.
		/// </summary>
		public DbSet<User> Users { get; set; }
	}
}