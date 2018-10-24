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
		/// <param name="options">The options.</param>
		public UsedCarsDbContext(DbContextOptions options) : base(options)
		{

		}

		/// <summary>
		/// Gets or sets the advertisements.
		/// </summary>>
		public DbSet<Advertisement> Advertisement { get; set; }

		/// <summary>
		/// Gets or sets the manufacturers.
		/// </summary>
		public DbSet<Manufacturer> Manufacturer { get; set; }

		/// <summary>
		/// Gets or sets the models.
		/// </summary>
		public DbSet<CarModel> CarModel { get; set; }

		/// <summary>
		/// Gets or sets the users.
		/// </summary>
		public DbSet<User> User { get; set; }

		/// <summary>
		/// Gets or sets the transmission types.
		/// </summary>
		public DbSet<TransmissionType> TransmissionType { get; set; }

		/// <summary>
		/// Gets or sets the engine types.
		/// </summary>
		public DbSet<EngineType> EngineType { get; set; }

		/// <summary>
		/// Gets or sets the photos.
		/// </summary>
		public DbSet<Photo> Photo { get; set; }

		/// <summary>
		/// Gets or sets the engine.
		/// </summary>
		public DbSet<Engine> Engine { get; set; }

		/// <summary>
		/// Gets or sets the transmission.
		/// </summary>
		public DbSet<Transmission> Transmission { get; set; }

		/// <summary>
		/// Gets or sets the type of the gear box.
		/// </summary>
		public DbSet<GearBoxType> GearBoxType { get; set; }

		/// <summary>
		/// Gets or sets the car.
		/// </summary>
		public DbSet<Car> Car { get; set; }
	}
}