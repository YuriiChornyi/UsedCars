using DAL.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL
{
	/// <summary>
	/// UsedCarsDbContextFactory
	/// </summary>
	/// <seealso cref="UsedCarsDbContext" />
	public class UsedCarsDbContextFactory : IDesignTimeDbContextFactory<UsedCarsDbContext>
	{
		/// <summary>
		/// Creates a new instance of a derived context.
		/// </summary>
		/// <param name="args">Arguments provided by the design-time service.</param>
		public UsedCarsDbContext CreateDbContext(string[] args)
		{
			var builder = new DbContextOptionsBuilder<UsedCarsDbContext>();
			builder.UseSqlServer(ConnectionStringHelper.Get());

			return new UsedCarsDbContext(builder.Options);
		}
	}
}
