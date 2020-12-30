using Autofac;
using System.Reflection;
using WindPowerSystemV2.Services;
using WindPowerSystemV2.Services.Interfaces;
using Module = Autofac.Module;
using NHibernate;
using NHibernate.Cfg;
using WindPowerSystemV2.Helpers;

namespace WindPowerSystemV2.DI
{
	public class DefaultDIModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			//Registration All repositories 
			builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
				.Where(t => t.Name.EndsWith(Constants.Repository))
				.AsImplementedInterfaces();

			//Registration Base Functionality
			builder.RegisterType<BaseService>().As<IBaseService>();

			//Registration Services
			builder.RegisterType<TurbineTypeService>().As<ITurbineTypeService>().PropertiesAutowired();
			builder.RegisterType<TurbineService>().As<ITurbineService>().PropertiesAutowired();

			//Registration NHibernate (connected to Oracle DB) 
			var cfg = (Configuration)builder.Properties[Constants.NHibernateConfiguration];

			builder.Register(c => cfg.BuildSessionFactory())
				.As<ISessionFactory>()
				.SingleInstance();

			builder.Register(c => c.Resolve<ISessionFactory>().OpenSession());
		}
	}
}
