using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WindPowerSystemV2.DI;
using WindPowerSystemV2.Repositories;


namespace WindPowerSystemV2
{
	public class Startup
	{
		public IConfiguration Configuration { get; }
		private static IContainer Container { get; set; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public IServiceProvider ConfigureServices(IServiceCollection services)
		{
			var builder = new ContainerBuilder();
			services.AddMvc();

			// Add EntityFramework support for SqlServer.
			services.AddEntityFrameworkSqlServer();

			// Add ApplicationDbContext.
			services.AddDbContext<Context>(options =>
				options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
			);
			services.AddAutoMapper(typeof(Startup));

			builder.RegisterModule<DefaultDIModule>();
			builder.Populate(services);

			Container = builder.Build();

			return new AutofacServiceProvider(Container);
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
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");

				routes.MapSpaFallbackRoute(
					name: "spa-fallback",
					defaults: new { controller = "Home", action = "Index" });
			});

			//Create a service scope to get an Context instance using DI
			using (var serviceScope =
				app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
			{
				var dbContext = serviceScope.ServiceProvider.GetService<Context>();
				
				// Create the Db if it doesn't exist and applies any pending migration.
				dbContext.Database.Migrate();

				// Seed the Db.
				DbSeeder.Seed(dbContext);
			}
		}
	}
}
