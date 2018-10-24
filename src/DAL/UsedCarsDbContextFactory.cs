using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DAL
{
	/// <summary>
	/// UsedCarsDbContextFactory
	/// </summary>
	/// <seealso cref="Microsoft.EntityFrameworkCore.Design.IDesignTimeDbContextFactory{DAL.UsedCarsDbContext}" />
	public class UsedCarsDbContextFactory : IDesignTimeDbContextFactory<UsedCarsDbContext>
	{
		/// <summary>
		/// Creates a new instance of a derived context.
		/// </summary>
		/// <param name="args">Arguments provided by the design-time service.</param>
		public UsedCarsDbContext CreateDbContext(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("./appsettings.json") //when UsedCars project is in startup mode
				.Build();

			var builder = new DbContextOptionsBuilder<UsedCarsDbContext>();
			builder.UseSqlServer(configuration.GetConnectionString("UsedCarsDatabase"));

			return new UsedCarsDbContext(builder.Options);
		}
	}
}
