using Autofac;
using System.Reflection;
using WindPowerSystemV2.Services;
using WindPowerSystemV2.Services.Interfaces;
using Module = Autofac.Module;

namespace WindPowerSystemV2.DI
{
	public class DefaultDIModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			//Registration All repositories 
			builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
				.Where(t => t.Name.EndsWith("Repository"))
				.AsImplementedInterfaces();

			//Registration Base Functionality
			builder.RegisterType<BaseService>().As<IBaseService>();

			//Registration Services
			builder.RegisterType<TurbineTypeService>().As<ITurbineTypeService>().PropertiesAutowired();
		}
	}
}
