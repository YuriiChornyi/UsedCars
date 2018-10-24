using System;
using System.Collections.Generic;
using Autofac;
using DAL;
using DAL.Entities;
using DAL.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace UsedCars
{
	public class Startup
	{
		/// <summary>
		/// Gets the configuration.
		/// </summary>
		public IConfiguration Configuration { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Startup"/> class.
		/// </summary>
		/// <param name="configuration">The configuration.</param>
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public IServiceProvider ConfigureServices(IServiceCollection services)
		{
			services.AddMvc()
				.SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

			services.AddDbContext<UsedCarsDbContext>(optionsBuilder =>
				optionsBuilder.UseSqlServer(Configuration.GetConnectionString("UsedCarsDatabase")));
			var builder = new ContainerBuilder();

			builder.Populate(services);

			builder.Register(c => new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>())).AsSelf().SingleInstance();

			//registe mapper
			builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();
			builder.RegisterType<UsedCarsDbContext>();
			builder.RegisterType<UserService>().As<IUserService>();

			builder.RegisterType<UserRepository>().As<IUserRepository>().SingleInstance();
			builder.RegisterType<GenericRepository<Car>>().As<IRepository<Car>>().SingleInstance();
			builder.RegisterType<AdvertisementRepository>().As<IAdvertisementRepository>().SingleInstance();


			var container = builder.Build();

			//Create the IServiceProvider based on the container.
			return new AutofacServiceProvider(container);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller}/{action}/{id?}");
			});

		}
	}
}