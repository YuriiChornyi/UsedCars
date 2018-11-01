using System.IO;
using Microsoft.Extensions.Configuration;

namespace DAL.Helpers
{
	public static class ConnectionStringHelper
	{
		private static IConfigurationRoot configuration = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("./appsettings.json") //when UsedCars project is in startup mode
			.Build();

		public static string Get()
		{
			return configuration.GetConnectionString("UsedCarsDatabase");
		}
	}
}
