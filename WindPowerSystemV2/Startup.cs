using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WindPowerSystemV2.DI;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;
using WindPowerSystemV2.Helpers;

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

			services.AddAutoMapper(typeof(Startup));

			builder.RegisterModule<DefaultDIModule>();
			builder.Populate(services);

			AddNHibConfigurationToBuilder(builder);

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
				app.UseHsts();
				app.UseExceptionHandler("/Home/Error");
			}

			app.UseHttpsRedirection();
			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller=Home}/{action=Index}/{id?}");

				routes.MapSpaFallbackRoute(
					name: "spa-fallback",
					defaults: new { controller = "Home", action = "Index" });
			});
		}

		private void AddNHibConfigurationToBuilder(ContainerBuilder builder)
		{
			string oraConnection = Configuration.GetConnectionString("DefaultOraConnection");

			var cfg = new Configuration();

			cfg.DataBaseIntegration(x =>
			{
				x.ConnectionString = oraConnection;
				x.Driver<OracleManagedDataClientDriver>();
				x.Dialect<Oracle12cDialect>();
			});

			var assembly = Assembly.GetExecutingAssembly();

			cfg.AddAssembly(assembly);

			builder.Properties.Add(Constants.NHibernateConfiguration, cfg);
		}
	}
}
