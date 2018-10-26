using Microsoft.AspNetCore.Hosting;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore;

namespace UsedCars
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateWebHostBuilder(args).Build().Run();
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.ConfigureServices(services => services.AddAutofac())
				//.UseUrls("http://localhost:5000", "https://localhost:5001", "https://178.210.131.216:5001")
				.UseStartup<Startup>();
	}
}
